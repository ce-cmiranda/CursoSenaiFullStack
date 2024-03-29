import { Component, OnInit } from '@angular/core';
import { Cadastro } from '../cadastro.model';
import { CadastroService } from '../cadastro.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cadastro-create',
  templateUrl: './cadastro-create.component.html',
  styleUrls: ['./cadastro-create.component.css']
})
export class CadastroCreateComponent implements OnInit {

  cadastro: Cadastro =
  {
    usuario: '',
    senha: ''
  }
  constructor(private cadastroService: CadastroService, private router:Router) { }

  ngOnInit(): void {
  }

  createCadastro(): void{
    this.cadastroService.create(this.cadastro).subscribe(()=>{
      this.cadastroService.showMessage('Usuário cadastrado!')
      this.router.navigate(['cadastro/tabela'])
    })
  }

  tabelasCadastro(){
    this.router.navigate(['cadastro/tabela'])
  }
  
  cancelarCadastro(){
    this.router.navigate([''])
  }
}
