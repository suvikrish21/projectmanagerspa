import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjmodalComponent } from './projmodal.component';

describe('ProjmodalComponent', () => {
  let component: ProjmodalComponent;
  let fixture: ComponentFixture<ProjmodalComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjmodalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjmodalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
