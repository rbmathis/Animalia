namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Podomys;

/// <summary>
/// Species: Podomys floridanus
/// NCBI TaxId: 56323
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Podomys_floridanus : Podomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Podomys floridanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Podomys_floridanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56323;
}
