namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.Potamotrygon;

/// <summary>
/// Species: Potamotrygon tigrina
/// NCBI TaxId: 2283129
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Potamotrygon_tigrina : Potamotrygon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Potamotrygon tigrina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Potamotrygon_tigrina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2283129;
}
