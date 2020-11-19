import { saveAs } from 'file-saver';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DownloadCsvService {

  constructor() { }

  downloadFile(data: any, fileName: string) {
    const replacer = (key, value) => value === null ? 'NO RECORD' : value;
    const header = Object.keys(data[0]);
    const csv = data.map(row => header.map(fieldName => JSON.stringify(row[fieldName], replacer)).join(','));
    csv.unshift(header.join(','));
    const csvArray = csv.join('\r\n');
    const blob = new Blob([csvArray], { type: 'text/csv' });
    saveAs(blob, fileName);
  }
}
