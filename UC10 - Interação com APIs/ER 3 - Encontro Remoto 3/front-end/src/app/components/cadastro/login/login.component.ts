import { Component, OnInit } from '@angular/core';
import { Cadastro } from '../cadastro.model';
import { CadastroService } from '../cadastro.service';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  cadastro: Cadastro =
  {
    usuario: '',
    senha: ''
  }

  cadastros!: Cadastro[]

  
  constructor(private cadastroService: CadastroService, private router:Router) { }

  ngOnInit(): void {
  }

  // createCadastro(): void{



  //     this.verificaCadastro(this.cadastro)

  // }

  verificaCadastro()
  {
    
    if(this.cadastroService.testSQLInjection(this.cadastro)){
      this.cadastroService.read().subscribe(cadastros=>
        {
          this.cadastros = cadastros
          console.log(this.cadastros)
          console.log(this.cadastro)
          this.doSomething()   
        })
    }
  }

  doSomething()
  {
    let usuario = this.cadastros.find(o => o.usuario.toLowerCase() === this.cadastro.usuario.toLowerCase());
    if (Boolean(usuario) && usuario?.senha == this.cadastro.senha)
    {
      this.cadastroService.showMessage('Sucesso')
      this.router.navigate(['cadastro/tabela'])
      
    }
    else
    {
      this.cadastroService.showMessage('Usuário não encontrado ou senha incorreta!')
    }
  }
  // tabelasCadastro(){
  //   this.router.navigate(['cadastro/tabela'])
  // }
  
  novoCadastro(){
    this.router.navigate(['cadastro/'])
  }
}