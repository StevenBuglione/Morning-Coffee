import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MainDashBoardComponent } from './main-dash-board.component';

describe('MainDashBoardComponent', () => {
  let component: MainDashBoardComponent;
  let fixture: ComponentFixture<MainDashBoardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MainDashBoardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MainDashBoardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
