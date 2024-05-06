using SingleResponsability;

StudentRepository studentRepository = new();
ExportCsv exportCsv = new();
exportCsv.Export(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");