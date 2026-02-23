namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.Potamotrygon;

/// <summary>
/// Species: Potamotrygon rex
/// NCBI TaxId: 2803086
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Potamotrygon_rex : Potamotrygon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Potamotrygon rex";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Potamotrygon_rex";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2803086;
}
