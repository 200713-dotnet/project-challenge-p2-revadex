import { TestBed } from '@angular/core/testing';

import { AllconstellationsService } from './allconstellations.service';

describe('AllconstellationsService', () => {
  let service: AllconstellationsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AllconstellationsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
