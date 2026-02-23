namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus obscurus
/// NCBI TaxId: 523745
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_obscurus : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus obscurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_obscurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 523745;
}
