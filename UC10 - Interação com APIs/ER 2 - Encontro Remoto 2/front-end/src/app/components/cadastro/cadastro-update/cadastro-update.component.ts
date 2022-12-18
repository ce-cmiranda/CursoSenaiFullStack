import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Cadastro } from '../cadastro.model';
import { CadastroService } from '../cadastro.service';


@Component({
  selector: 'app-cadastro-update',
  templateUrl: './cadastro-update.component.html',
  styleUrls: ['./cadastro-update.component.css']
})
export class CadastroUpdateComponent implements OnInit {

  cadastro: Cadastro
  =
  {
    usuario: '',
    senha: ''
  }
  ;
  constructor(
    private cadastroService: CadastroService,
    private router:Router,
    private route: ActivatedRoute){ }

  ngOnInit(): void {
    const id = +this.route.snapshot.paramMap.get('id')!;
    // console.log(id)
    this.cadastroService.readById(id).subscribe(cadastro=>{
      this.cadastro = cadastro!
      console.log(cadastro)
    })
  }

  updateCadastro(): void{
    this.cadastroService.updateCadastro(this.cadastro).subscribe(()=>{
      this.cadastroService.showMessage('Cadastro Atualizado!')
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
