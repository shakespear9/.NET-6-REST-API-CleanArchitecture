##Login

```json
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "email":"nuttakorn@tedthong.com",
    "password:"leen1234!"
}

```

```json
200 OK
```

#### Login Response

```json
{
  "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
  "firstName": "Nuttakorn",
  "lastName": "Tedthong",
  "email": "nuttakorn@tedthong.com",
  "token": "abcdef.asdasd..."
}
```
