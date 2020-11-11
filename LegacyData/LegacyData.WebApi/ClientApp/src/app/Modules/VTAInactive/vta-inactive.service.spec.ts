import { TestBed } from '@angular/core/testing';

import { VtaInactiveService } from './vta-inactive.service';

describe('VtaInactiveService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: VtaInactiveService = TestBed.get(VtaInactiveService);
    expect(service).toBeTruthy();
  });
});
