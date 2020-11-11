import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VtaInactiveIdComponent } from './vta-inactive-id.component';

describe('VtaInactiveIdComponent', () => {
  let component: VtaInactiveIdComponent;
  let fixture: ComponentFixture<VtaInactiveIdComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VtaInactiveIdComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VtaInactiveIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
