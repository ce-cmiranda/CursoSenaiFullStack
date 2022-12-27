import { Input, Component, Output, EventEmitter, OnInit } from '@angular/core';
// import { FormGroup, FormControl } from '@angular/forms';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor() { }
  loginForm: FormGroup = new FormGroup({
    email: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', [Validators.required]),
  });

  email = '';
  password = '';

  login() {
    if (this.loginForm.valid) {
      this.submitEM.emit(this.loginForm.value);
      console.log(this.loginForm.value)
    }
  }
  // @Input() error: string | null;

  @Output() submitEM = new EventEmitter();

  ngOnInit(): void {
  }

}
