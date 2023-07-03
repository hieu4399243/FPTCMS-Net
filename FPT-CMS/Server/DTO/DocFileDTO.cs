﻿using Server.Entity.Enum;

namespace Server.DTO;

public class DocFileDTO
{
    public int Id { get; set; }
    public string UploadFile { get; set; }
    public FileType FileType { get; set; }
    public int DocumentationId { get; set; }
}