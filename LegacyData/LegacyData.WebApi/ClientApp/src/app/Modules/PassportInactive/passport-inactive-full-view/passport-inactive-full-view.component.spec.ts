import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PassportInactiveFullViewComponent } from './passport-inactive-full-view.component';

describe('PassportInactiveFullViewComponent', () => {
  let component: PassportInactiveFullViewComponent;
  let fixture: ComponentFixture<PassportInactiveFullViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PassportInactiveFullViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PassportInactiveFullViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
