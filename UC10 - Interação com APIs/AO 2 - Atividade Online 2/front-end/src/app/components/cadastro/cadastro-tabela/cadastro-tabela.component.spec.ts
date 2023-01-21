import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastroTabelaComponent } from './cadastro-tabela.component';

describe('CadastroTabelaComponent', () => {
  let component: CadastroTabelaComponent;
  let fixture: ComponentFixture<CadastroTabelaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CadastroTabelaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CadastroTabelaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
