import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PassportInactiveComponent } from './passport-inactive.component';

describe('PassportInactiveComponent', () => {
  let component: PassportInactiveComponent;
  let fixture: ComponentFixture<PassportInactiveComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PassportInactiveComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PassportInactiveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
