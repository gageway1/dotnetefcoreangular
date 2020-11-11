import { TestBed } from '@angular/core/testing';

import { PassportInactiveService } from './passport-inactive.service';

describe('PassportInactiveService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PassportInactiveService = TestBed.get(PassportInactiveService);
    expect(service).toBeTruthy();
  });
});
