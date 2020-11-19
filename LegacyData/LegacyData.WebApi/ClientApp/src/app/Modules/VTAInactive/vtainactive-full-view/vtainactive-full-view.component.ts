import { DownloadCsvService } from './../../Shared/shared/services/download-csv.service';
import { VTA } from './../../../Models/vta';
import { VtaInactiveService } from './../vta-inactive.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { saveAs } from 'file-saver';

@Component({
  selector: 'app-vtainactive-full-view',
  templateUrl: './vtainactive-full-view.component.html',
  styleUrls: ['./vtainactive-full-view.component.css']
})
export class VTAInactiveFullViewComponent implements OnInit {
  public id: number;
  public vtaEntry: VTA;
  constructor(
    private route: ActivatedRoute,
    private service: VtaInactiveService,
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
        this.service.getFullVTAEntryById(this.id).subscribe(res => {
          if (res) {
            this.vtaEntry = res;
          }
        });
      }
    });
  }

  public downloadFile(vta: any) {
    const newArr = [];
    newArr.push(vta);
    this.downloadCsv.downloadFile(newArr, `${this.vtaEntry.firstname}_${this.vtaEntry.lastname}_FULL_ENTRY_${this.vtaEntry.id}_${new Date}.csv`);
  }


}
