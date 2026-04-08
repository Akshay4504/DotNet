import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyHeros } from './my-heros';

describe('MyHeros', () => {
  let component: MyHeros;
  let fixture: ComponentFixture<MyHeros>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MyHeros],
    }).compileComponents();

    fixture = TestBed.createComponent(MyHeros);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
