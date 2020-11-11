import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { VTA } from 'src/app/Models/vta';
import { VtaInactiveService } from '../../vta-inactive.service';

@Component({
  selector: 'app-vta-inactive',
  templateUrl: './vta-inactive.component.html',
  styleUrls: ['./vta-inactive.component.css']
})
export class VtaInactiveComponent implements OnInit {
  public vtas: VTA[];
  public form: FormGroup;
  public submitted: boolean = false;

  constructor(
    private fb: FormBuilder,
    private service: VtaInactiveService,
    private toast: ToastrService
  ) { }

  ngOnInit(): void {
    this.loadView();
  }

  public loadView(): void {
    this.buildForm();
  }

  public buildForm() {
    this.form = this.fb.group({
      firstName: [],
      lastName: []
    });
  }

  public submitForm(form: FormGroup) {
    this.vtas = null;
    if (this.form.get('firstName').value || this.form.get('lastName').value) {
      this.submitted = true;
      this.form = form;
      this.service.getVtaInactiveDataByName(this.form.get('firstName').value, this.form.get('lastName').value).subscribe(res => {
        if (res) {
          this.vtas = res;
          if (this.vtas.length == 0) {
            this.vtas = null;
          }
          console.log(res);
        }
      }, err => {
        console.log('Error retrieving request: ', err);
        this.toast.error("Error retrieving request.", "Error", { positionClass: 'toast-bottom-right' });
      });
    }
    else {
      if (this.toast.currentlyActive) { }
      this.form.markAsDirty();
      this.form.markAllAsTouched();
      this.toast.toastrConfig.preventDuplicates = true;
      this.toast.warning('Please enter a value.', null, { positionClass: 'toast-bottom-right' });

    }
  }
}
