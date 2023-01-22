import { HttpClient } from '@angular/common/http';

import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { EMPTY } from 'rxjs';

import { Observable } from 'rxjs/internal/Observable';
import { Cadastro } from './cadastro.model';
import { map, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class CadastroService {

  baseUrl = "http://localhost:3001/login"
  constructor(private snackBar: MatSnackBar, private http: HttpClient) { }

  showMessage(msg: string, isError: boolean = false): void {
    this.snackBar.open(msg, 'X', {
      duration: 6000,
      verticalPosition: 'bottom',
      panelClass: isError ? ['errorMsg'] : ['successMsg']
    });
  }

  errorMsg(e: any): Observable<any> {
    console.log(e.status);
    let msg = ''
    switch (e.status) {
      case 404: {
        //statements; 
        msg = 'A pesquisa realizada não encontrou nenhum resultado'
        break;
      }
      case 0: {
        //statements; 
        msg = 'Sem resposta do back-end'
        break;
      }
      case 401: {
        //statements; 
        msg = 'Falha de autenticação'
        break;
      }
      case 403: {
        //statements; 
        msg = 'Não há permissões para realizar esta ação'
        break;
      }
      case 405: {
        //statements; 
        msg = 'Método não permitido'
        break;
      }

      case 405: {
        //statements; 
        msg = 'Mídia não suportada.'
        break;
      }

      case 405: {
        //statements; 
        msg = 'Falha de validação de dados.'
        break;
      }

      case 405: {
        //statements; 
        msg = 'Excesso de requisições.'
        break;
      }
      case 405: {
        //statements; 
        msg = 'Erro interno do servidor.'
        break;
      }
      default: {
        //statements;
        msg = 'Erro não identificado'
        break;
      }
    }

    this.showMessage(msg, true)
    return EMPTY
  }

  testSQLInjection(cadastro: Cadastro){
    // const url = `${this.baseUrl}/${cadastro.id}`
    // return this.http.put<Cadastro>(url, cadastro)
    const blackList = ["SELECT", "OR", ' ""="" ', "-- ", ";", "1 = 1", "1=1", "DROP", "\"\"=\"\"", "'='"];//lista de palavras chave
    let ataque = 0;

    blackList.forEach((palavra) => {
      if (cadastro.usuario?.toUpperCase().includes(palavra) || cadastro.senha?.toUpperCase().includes(palavra)) {//encontrou sql injection
        ataque++;
      }
    });

    if (ataque > 0) {//campos vazios ou está sob ataque
      this.showMessage("Usuário ou senhas não permitidos. Por favor tente novamente!", true)
      return false
    }
    
    return true
  }


  create(cadastro: Cadastro): Observable<Cadastro> {
    
    if (this.testSQLInjection(cadastro))
    {
      return this.http.post<Cadastro>(this.baseUrl, cadastro).pipe(
        map((obj) => obj),
        catchError(e => this.errorMsg(e))
      )
    }
    return EMPTY;
  }

  read(): Observable<Cadastro[]> {
    return this.http.get<Cadastro[]>(this.baseUrl)
  }

  readById(id: number): Observable<Cadastro> {
    const url = `${this.baseUrl}/${id}`
    console.log(url)
    return this.http.get<Cadastro>(url).pipe(
      map((obj) => obj),
      catchError(e => this.errorMsg(e))
    )
  }

  updateCadastro(cadastro: Cadastro): Observable<Cadastro> {

    if (this.testSQLInjection(cadastro))
    {
      const url = `${this.baseUrl}/${cadastro.id}`
      return this.http.put<Cadastro>(url, cadastro)
    }
    return EMPTY;

  }

  deleteCadastro(cadastro: Cadastro): Observable<Cadastro> {
    const url = `${this.baseUrl}/${cadastro.id}`
    return this.http.delete<Cadastro>(url)
  }
}

