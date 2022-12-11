import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ConstrucaoComponent } from './views/construcao/construcao.component';
// import { pathToFileURL } from 'url';
import { HomeComponent } from './views/home/home.component';
import { LoginComponent } from './views/login/login.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'construcao', component: ConstrucaoComponent },
  { path: 'login', component: LoginComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
