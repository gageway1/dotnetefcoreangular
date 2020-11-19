import { TestBed } from '@angular/core/testing';

import { DownloadCsvService } from './download-csv.service';

describe('DownloadCsvService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: DownloadCsvService = TestBed.get(DownloadCsvService);
    expect(service).toBeTruthy();
  });
});
