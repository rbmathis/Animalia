namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Thomomys;

/// <summary>
/// Species: Thomomys townsendii
/// NCBI TaxId: 10012
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thomomys_townsendii : Thomomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thomomys townsendii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thomomys_townsendii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10012;
}
