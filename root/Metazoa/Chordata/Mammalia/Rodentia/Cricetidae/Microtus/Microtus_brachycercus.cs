namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus brachycercus
/// NCBI TaxId: 905038
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_brachycercus : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus brachycercus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_brachycercus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 905038;
}
