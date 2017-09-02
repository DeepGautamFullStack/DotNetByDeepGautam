import { TestBed, inject } from '@angular/core/testing';

import { ConsumeRestAPIService } from './consume-rest-api.service';

describe('ConsumeRestAPIService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ConsumeRestAPIService]
    });
  });

  it('should be created', inject([ConsumeRestAPIService], (service: ConsumeRestAPIService) => {
    expect(service).toBeTruthy();
  }));
});
