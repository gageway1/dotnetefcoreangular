import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VTAInactiveFullViewComponent } from './vtainactive-full-view.component';

describe('VTAInactiveFullViewComponent', () => {
  let component: VTAInactiveFullViewComponent;
  let fixture: ComponentFixture<VTAInactiveFullViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VTAInactiveFullViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VTAInactiveFullViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
