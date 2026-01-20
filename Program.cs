builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddSignalR();
builder.Services.AddAuthentication().AddJwtBearer();
