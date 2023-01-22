import { Component, OnInit } from '@angular/core';
import { Cadastro } from '../cadastro.model';
import { CadastroService } from '../cadastro.service';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';

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
  
  cadastros!: Cadastro[]

  
  constructor(private cadastroService: CadastroService, private router:Router) { }

  ngOnInit(): void {
  }

  createCadastro(): void{



      this.verificaCadastro(this.cadastro)

  }

  verificaCadastro(cadastro: Cadastro)
  {    
    this.cadastroService.read().subscribe(cadastros=>
      {
        this.cadastros = cadastros
        // console.log(this.cadastros)
        this.doSomething()
      
      })
  }

  doSomething()
  {
    let usuario = this.cadastros.find(o => o.usuario.toLowerCase() === this.cadastro.usuario.toLowerCase());
    let format = /[ `!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?~]/;
    let alphanum = /^(?=.*[a-zA-Z])(?=.*[0-9])/;

    if (Boolean(usuario))
    {
      this.cadastroService.showMessage('Usuário já existe!')
    }
    else if ( this.cadastro.usuario.length <8)
    {
      this.cadastroService.showMessage('O usuário precisa ter mais que 8 caracteres!')
    }

    else if (format.test(this.cadastro.usuario))
    {
      this.cadastroService.showMessage('Usuário não pode ter caracteres especiais!')
    }
    else if (this.cadastro.senha.length <8 || this.cadastro.senha.length >15)
    {
      this.cadastroService.showMessage('A senha precisa ter entre 8 e 15 caracteres!')
    }

    else if (!format.test(this.cadastro.senha))
    {
      this.cadastroService.showMessage('A senha precisa ter caracteres especiais!')
    }

    else if (!alphanum.test(this.cadastro.senha))
    {
      this.cadastroService.showMessage('A senha precisa ter números e letras!')
    }
    else
    {
      this.cadastroService.create(this.cadastro).subscribe(()=>{
        this.cadastroService.showMessage('Usuário cadastrado!')
        this.router.navigate(['cadastro/tabela'])
      })
    }
  }
  tabelasCadastro(){
    this.router.navigate(['cadastro/tabela'])
  }
  
  cancelarCadastro(){
    this.router.navigate([''])
  }
}
