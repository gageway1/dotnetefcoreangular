import { DownloadCsvService } from './../../Shared/shared/services/download-csv.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Passport } from 'src/app/Models/passport';
import { PassportInactiveService } from '../passport-inactive.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-passport-inactive-id',
  templateUrl: './passport-inactive-id.component.html',
  styleUrls: ['./passport-inactive-id.component.css']
})
export class PassportInactiveIdComponent implements OnInit {

  public passport: Passport[];
  public form: FormGroup;
  public submitted = false;
  public id: number;


  constructor(
    private route: ActivatedRoute,
    private fb: FormBuilder,
    private service: PassportInactiveService,
    private toast: ToastrService,
    private downloadService: DownloadCsvService
  ) { }

  ngOnInit(): void {
    this.loadView();
  }

  public loadView(): void {
    this.id = null;
    this.route.queryParams.subscribe(params => {
      if (params['id'] !== null && params['id'] !== undefined) {
        console.log(params['id']);
        this.id = params['id'];
        this.service.getPassportDataById(this.id).subscribe(res => {
          if (res.length !== 0) {
            this.passport = res;
            console.log(res);
          }
        }, err => {
          console.log('Error retrieving request: ', err);
          this.toast.error('Error retrieving request.', 'Error', { positionClass: 'toast-bottom-right' });
        });
      }
    });
    this.buildForm();
  }

  public buildForm() {
    this.form = this.fb.group({
      id: [this.id || null, []]
    });
  }

  public submitForm(form: FormGroup) {
    if (this.form.value) {
      this.submitted = true;
      this.form = form;
      this.service.getPassportDataById(this.form.get('id').value).subscribe(res => {
        if (res.length !== 0) {
          this.passport = res;
          console.log(res);
        }
      }, err => {
        console.log('Error retrieving request: ', err);
        this.toast.error('Error retrieving request.', 'Error', { positionClass: 'toast-bottom-right' });
      });
    } else {
      this.form.markAsDirty();
      this.form.markAllAsTouched();
      this.toast.toastrConfig.preventDuplicates = true;
      this.toast.warning('Please enter a value.', null, { positionClass: 'toast-bottom-right' });
    }
  }

  public downloadList(vta: any) {
    this.passport = vta;
    this.downloadService.downloadFile(vta, `${this.passport[0].userFirstName}_${this.passport[0].userLastName}_COURSE_LIST_${this.passport[0].id}_${new Date}.csv`);
  }

}
