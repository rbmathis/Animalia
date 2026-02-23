namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Melopsittacus;

/// <summary>
/// Species: Melopsittacus undulatus
/// NCBI TaxId: 13146
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Melopsittacus_undulatus : Melopsittacus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Melopsittacus undulatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Melopsittacus_undulatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 13146;
}
