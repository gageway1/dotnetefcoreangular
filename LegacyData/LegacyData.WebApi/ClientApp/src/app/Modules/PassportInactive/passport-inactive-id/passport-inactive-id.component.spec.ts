import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PassportInactiveIdComponent } from './passport-inactive-id.component';

describe('PassportInactiveIdComponent', () => {
  let component: PassportInactiveIdComponent;
  let fixture: ComponentFixture<PassportInactiveIdComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PassportInactiveIdComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PassportInactiveIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
