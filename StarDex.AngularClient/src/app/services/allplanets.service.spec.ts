import { TestBed } from '@angular/core/testing';

import { AllplanetsService } from './allplanets.service';

describe('AllplanetsService', () => {
  let service: AllplanetsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AllplanetsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
