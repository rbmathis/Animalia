namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus canicaudus
/// NCBI TaxId: 100896
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_canicaudus : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus canicaudus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_canicaudus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100896;
}
