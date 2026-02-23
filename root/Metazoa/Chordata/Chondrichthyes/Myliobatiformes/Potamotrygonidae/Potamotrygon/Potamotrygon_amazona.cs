namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.Potamotrygon;

/// <summary>
/// Species: Potamotrygon amazona
/// NCBI TaxId: 2803078
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Potamotrygon_amazona : Potamotrygon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Potamotrygon amazona";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Potamotrygon_amazona";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2803078;
}
