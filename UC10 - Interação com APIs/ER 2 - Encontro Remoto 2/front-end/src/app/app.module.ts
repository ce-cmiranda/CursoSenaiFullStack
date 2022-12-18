import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CadastroCreateComponent } from './components/cadastro/cadastro-create/cadastro-create.component';
import { CadastroTabelaComponent } from './components/cadastro/cadastro-tabela/cadastro-tabela.component';


import { HttpClientModule } from '@angular/common/http';


import {MatFormFieldModule} from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { FormsModule } from '@angular/forms';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatTableModule } from '@angular/material/table';


import { CadastroReadComponent } from './components/cadastro/cadastro-read/cadastro-read.component';
import { CadastroUpdateComponent } from './components/cadastro/cadastro-update/cadastro-update.component';
import { CadastroDeleteComponent } from './components/cadastro/cadastro-delete/cadastro-delete.component';




@NgModule({
  declarations: [
    AppComponent,
    CadastroCreateComponent,
    CadastroTabelaComponent,
    CadastroReadComponent,
    CadastroUpdateComponent,
    CadastroDeleteComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatFormFieldModule,
    FormsModule,
    MatSnackBarModule,
    HttpClientModule,
    MatInputModule,
    BrowserAnimationsModule,
    MatTableModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
