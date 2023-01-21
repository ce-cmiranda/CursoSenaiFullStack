import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastroDeleteComponent } from './cadastro-delete.component';

describe('CadastroDeleteComponent', () => {
  let component: CadastroDeleteComponent;
  let fixture: ComponentFixture<CadastroDeleteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CadastroDeleteComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CadastroDeleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
