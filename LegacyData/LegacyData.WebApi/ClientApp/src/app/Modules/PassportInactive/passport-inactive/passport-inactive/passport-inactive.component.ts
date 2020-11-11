import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Passport } from 'src/app/Models/passport';
import { PassportInactiveService } from '../../passport-inactive.service';

@Component({
  selector: 'app-passport-inactive',
  templateUrl: './passport-inactive.component.html',
  styleUrls: ['./passport-inactive.component.css']
})
export class PassportInactiveComponent implements OnInit {

  public passport: Passport;
  public form: FormGroup;
  public submitted: boolean = false;

  constructor(
    private fb: FormBuilder,
    private service: PassportInactiveService,
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
    if (this.form.get('id').value) {
      this.passport = null;
      this.submitted = true;
      this.form = form;
      this.service.getPassportDataById(this.form.get('id').value).subscribe(res => {
        if (res) {
          this.passport = res;
          console.log(this.passport);
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
