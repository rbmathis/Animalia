namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Thomomys;

/// <summary>
/// Species: Thomomys bulbivorus
/// NCBI TaxId: 113116
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thomomys_bulbivorus : Thomomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thomomys bulbivorus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thomomys_bulbivorus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 113116;
}
