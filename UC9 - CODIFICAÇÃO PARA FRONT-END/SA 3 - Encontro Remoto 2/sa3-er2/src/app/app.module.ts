import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './views/home/home.component';
import { LoginComponent } from './views/login/login.component';
import { ConstrucaoComponent } from './views/construcao/construcao.component';
import { NotfoundComponent } from './views/notfound/notfound.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { BannerComponent } from './components/banner/banner.component';
import { DestaquesComponent } from './components/destaques/destaques.component';
import { OfertasComponent } from './components/ofertas/ofertas.component';



// Form
import { ReactiveFormsModule } from '@angular/forms';

// Material
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatIconModule} from '@angular/material/icon';
import {MatCardModule} from '@angular/material/card';
import {MatFormFieldModule} from '@angular/material/form-field';
import { MatInput, MatInputModule } from '@angular/material/input';



@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    ConstrucaoComponent,
    NotfoundComponent,
    HeaderComponent,
    FooterComponent,
    BannerComponent,
    DestaquesComponent,
    OfertasComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatIconModule,
    MatCardModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
