import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { VTA } from 'src/app/Models/vta';
import { VtaInactiveService } from '../vta-inactive.service';

@Component({
  selector: 'app-vta-inactive-id',
  templateUrl: './vta-inactive-id.component.html',
  styleUrls: ['./vta-inactive-id.component.css']
})
export class VtaInactiveIdComponent implements OnInit {

  public vta: VTA;
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
      id: []
    });
  }

  public submitForm(form: FormGroup) {
    this.vta = null;
    if (this.form.value) {
      this.submitted = true;
      this.form = form;
      this.service.getVtaInactiveDataById(this.form.get('id').value).subscribe(res => {
        if (res) {
          this.vta = res;
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
