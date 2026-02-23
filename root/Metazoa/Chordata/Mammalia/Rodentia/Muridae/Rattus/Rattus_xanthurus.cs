namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

/// <summary>
/// Species: Rattus xanthurus
/// NCBI TaxId: 2683850
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rattus_xanthurus : Rattus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rattus xanthurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rattus_xanthurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2683850;
}
