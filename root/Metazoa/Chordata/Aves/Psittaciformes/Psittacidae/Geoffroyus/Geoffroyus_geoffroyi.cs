namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Geoffroyus;

/// <summary>
/// Species: Geoffroyus geoffroyi
/// NCBI TaxId: 2301437
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geoffroyus_geoffroyi : Geoffroyus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geoffroyus geoffroyi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geoffroyus_geoffroyi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2301437;
}
