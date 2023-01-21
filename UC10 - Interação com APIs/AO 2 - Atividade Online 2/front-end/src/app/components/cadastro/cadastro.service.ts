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
  create(cadastro: Cadastro): Observable<Cadastro> {
    return this.http.post<Cadastro>(this.baseUrl, cadastro).pipe(
      map((obj) => obj),
      catchError(e => this.errorMsg(e))
    )
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
    const url = `${this.baseUrl}/${cadastro.id}`
    return this.http.put<Cadastro>(url, cadastro)
  }

  deleteCadastro(cadastro: Cadastro): Observable<Cadastro> {
    const url = `${this.baseUrl}/${cadastro.id}`
    return this.http.delete<Cadastro>(url)
  }
}

