import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './views/home/home.component';
import { LoginComponent } from './views/login/login.component';
import { ProdutoComponent } from './views/produto/produto.component';

const routes: Routes = [
  {    path: "login",   component: LoginComponent},
  {    path: "produto", component: ProdutoComponent},
  {    path: "home",    component: HomeComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
