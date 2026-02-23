namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pelomys;

/// <summary>
/// Species: Pelomys fallax
/// NCBI TaxId: 121576
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelomys_fallax : Pelomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelomys fallax";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelomys_fallax";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 121576;
}
