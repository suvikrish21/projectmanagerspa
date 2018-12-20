import { TestBed } from '@angular/core/testing';

import { ProjmgrapiService } from './projmgrapi.service';

describe('ProjmgrapiService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ProjmgrapiService = TestBed.get(ProjmgrapiService);
    expect(service).toBeTruthy();
  });
});
