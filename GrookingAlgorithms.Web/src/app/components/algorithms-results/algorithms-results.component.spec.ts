import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AlgorithmsResultsComponent } from './algorithms-results.component';

describe('AlgorithmsResultsComponent', () => {
  let component: AlgorithmsResultsComponent;
  let fixture: ComponentFixture<AlgorithmsResultsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AlgorithmsResultsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AlgorithmsResultsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
