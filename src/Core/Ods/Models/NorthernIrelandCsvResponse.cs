﻿using CsvHelper.Configuration.Attributes;

namespace Core.Ods.Models;

public record NorthernIrelandCsvResponse
{
    [Index(0)][Name("ORGANISATIONCODE")] public string? OrganisationCode { get; set; }

    [Index(1)][Name("NAME")] public string? Name { get; set; }

    [Index(3)][Name("HIGH LEVEL HEALTH GEOGRAPHY")] public string? HighLevelHealthGeography { get; set; }

    [Index(4)][Name("ADDRESS LINE 1")] public string? AddressLine1 { get; set; }

    [Index(5)][Name("ADDRESS LINE 2")] public string? AddressLine2 { get; set; }

    [Index(6)][Name("ADDRESS LINE 3")] public string? AddressLine3 { get; set; }

    [Index(7)][Name("ADDRESS LINE 4")] public string? AddressLine4 { get; set; }

    [Index(8)][Name("ADDRESS LINE 5")] public string? AddressLine5 { get; set; }

    [Index(9)][Name("POSTCODE")] public string? PostCode { get; set; }

    [Index(10)][Name("OPEN DATE")] public string? OpenDate { get; set; }

    [Index(11)][Name("CLOSE DATE")] public string? CloseDate { get; set; }

    [Index(12)][Name("STATUS CODE")] public string? StatusCode { get; set; }

    [Index(13)][Name("ORGANISATION SUBTYPE CODE")] public string? OrganisationSubtypeCode { get; set; }

    [Index(14)][Name("PARENT ORGANISATION CODE")] public string? ParentOrganisationCode { get; set; }

    [Index(17)][Name("CONTACT TELEPHONE NUMBER")] public string? ContactTelephoneNumber { get; set; }

    [Index(21)][Name("AMENDED RECORD INDICATOR")] public string? AmendedRecordIndicator { get; set; }
}