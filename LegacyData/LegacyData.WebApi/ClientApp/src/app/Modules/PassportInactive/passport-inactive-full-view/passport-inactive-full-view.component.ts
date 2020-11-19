import { Passport } from './../../../Models/passport';
import { PassportInactiveService } from './../passport-inactive.service';
import { DownloadCsvService } from './../../Shared/shared/services/download-csv.service';
import { VTA } from './../../../Models/vta';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { saveAs } from 'file-saver';

@Component({
  selector: 'app-vtainactive-full-view',
  templateUrl: './passport-inactive-full-view.component.html',
  styleUrls: ['./passport-inactive-full-view.component.css']
})
export class PassportInactiveFullViewComponent implements OnInit {
  public id: number;
  public passport: Passport;
  constructor(
    private route: ActivatedRoute,
    private service: PassportInactiveService,
    private downloadCsv: DownloadCsvService,
  ) { }

  ngOnInit() {
    this.loadView();
  }

  public loadView(): void {
    this.getEntryById();
  }

  public getEntryById(): void {
    this.route.queryParams.subscribe(params => {
      if (params['id'] !== null) {
        this.id = params['id'];
        this.service.getFullPassportEntryById(this.id).subscribe(res => {
          if (res) {
            this.passport = res;
          }
        });
      }
    });
  }

  public downloadFile(vta: any) {
    const newArr = [];
    newArr.push(vta);
    this.downloadCsv.downloadFile(newArr, `${this.passport.userFirstName}_${this.passport.userLastName}_FULL_ENTRY_${this.passport.id}_${new Date}.csv`);
  }


}
