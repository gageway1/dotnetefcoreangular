import { DownloadCsvService } from './../../Shared/shared/services/download-csv.service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { VTA } from 'src/app/Models/vta';
import { VtaInactiveService } from '../vta-inactive.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-vta-inactive-id',
  templateUrl: './vta-inactive-id.component.html',
  styleUrls: ['./vta-inactive-id.component.css']
})
export class VtaInactiveIdComponent implements OnInit {

  public vta: VTA[];
  public form: FormGroup;
  public submitted: boolean = false;
  public id: number;

  constructor(
    private fb: FormBuilder,
    private service: VtaInactiveService,
    private toast: ToastrService,
    private route: ActivatedRoute,
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
        this.service.getVtaInactiveDataByEmployeeId(this.id).subscribe(res => {
          if (res.length !== 0) {
            this.vta = res;
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
      id: [this.id || null, Validators.required]
    });
  }

  public submitForm(form: FormGroup) {
    console.log(this.form);
    if (this.form.get('id').value !== null && this.form.valid) {
      this.submitted = true;
      this.form = form;
      this.service.getVtaInactiveDataByEmployeeId(this.form.get('id').value).subscribe(res => {
        if (res.length !== 0) {
          this.vta = res;
          console.log(this.vta);
        }
      }, err => {
        console.log('Error retrieving request: ', err);
        this.toast.error("Error retrieving request.", "Error", { positionClass: 'toast-bottom-right' });
      });
    }
    else {
      this.form.markAsDirty();
      this.form.markAllAsTouched();
      this.toast.toastrConfig.preventDuplicates = true;
      this.toast.warning('Please enter a valid value.', null, { positionClass: 'toast-bottom-right' });
    }
  }

  public downloadList(vta: any) {
    this.vta = vta;
    this.downloadService.downloadFile(vta, `${this.vta[0].firstname}_${this.vta[0].lastname}_COURSE_LIST_${this.vta[0].id}_${new Date}.csv`);
  }

}
