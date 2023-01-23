import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventosComponent } from './components/eventos/eventos.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'
import { PalestrantesComponent } from './components/palestrantes/palestrantes.component';
import { NavComponent } from './shared/nav/nav.component';
import { ToastrModule } from 'ngx-toastr';
import { NgxSpinnerModule } from 'ngx-spinner';

import { CollapseModule } from 'ngx-bootstrap/collapse';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { FormsModule } from '@angular/forms';
import { EventoService } from './services/evento.service';
import { DateTimeFormatPipe } from './helpers/DateTimeFormatPipe.pipe';
import { ModalModule } from 'ngx-bootstrap/modal';
import { ContatosComponent } from './components/contatos/contatos.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { PerfilComponent } from './components/perfil/perfil.component';
import { TituloComponent } from './shared/titulo/titulo.component';




@NgModule({
  declarations: [
    AppComponent,
      EventosComponent,
      PalestrantesComponent,
      NavComponent,
      ContatosComponent,
      DashboardComponent,
      PerfilComponent,
      DateTimeFormatPipe,
      TituloComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ModalModule.forRoot(),
    BrowserAnimationsModule,
    CollapseModule.forRoot(),
    FormsModule,
    BsDropdownModule.forRoot(),
    TooltipModule.forRoot(),
    ToastrModule.forRoot({
      timeOut: 30000,
      positionClass: 'toast-bottom-right',
      preventDuplicates: true,
      progressBar: true,
    }),
    NgxSpinnerModule,
  ],
  providers: [EventoService],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class AppModule { }
