import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cadastro-tabela',
  templateUrl: './cadastro-tabela.component.html',
  styleUrls: ['./cadastro-tabela.component.css']
})
export class CadastroTabelaComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
  }

  cadastro(){
    this.router.navigate(['cadastro'])
  }

  home(){
    this.router.navigate([''])
  }
}
