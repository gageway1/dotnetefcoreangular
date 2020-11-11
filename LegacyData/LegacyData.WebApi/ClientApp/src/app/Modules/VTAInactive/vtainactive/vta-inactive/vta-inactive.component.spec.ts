import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VtaInactiveComponent } from './vta-inactive.component';

describe('VtaInactiveComponent', () => {
  let component: VtaInactiveComponent;
  let fixture: ComponentFixture<VtaInactiveComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VtaInactiveComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VtaInactiveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
