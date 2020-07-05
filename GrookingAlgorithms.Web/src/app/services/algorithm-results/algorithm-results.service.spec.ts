import { TestBed } from '@angular/core/testing';

import { AlgorithmResultsService } from './algorithm-results.service';

describe('AlgorithmResultsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AlgorithmResultsService = TestBed.get(AlgorithmResultsService);
    expect(service).toBeTruthy();
  });
});
