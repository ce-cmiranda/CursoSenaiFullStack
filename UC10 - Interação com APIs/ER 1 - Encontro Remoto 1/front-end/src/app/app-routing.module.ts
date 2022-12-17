import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastroCreateComponent } from './components/cadastro/cadastro-create/cadastro-create.component';
import { CadastroDeleteComponent } from './components/cadastro/cadastro-delete/cadastro-delete.component';
import { CadastroTabelaComponent } from './components/cadastro/cadastro-tabela/cadastro-tabela.component';
import { CadastroUpdateComponent } from './components/cadastro/cadastro-update/cadastro-update.component';

const routes: Routes = [
  {
    path: '',
    component: CadastroCreateComponent,
  },
  {
    path: 'cadastro',
    component: CadastroCreateComponent,
  },
  {
    path: 'cadastro/tabela',
    component: CadastroTabelaComponent,
  },
  {
    path: 'cadastro/update/:id',
    component: CadastroUpdateComponent,
  },
  {
    path: 'cadastro/delete/:id',
    component: CadastroDeleteComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
