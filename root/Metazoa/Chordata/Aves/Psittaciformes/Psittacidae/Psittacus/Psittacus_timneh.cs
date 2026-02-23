namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacus;

/// <summary>
/// Species: Psittacus timneh
/// NCBI TaxId: 1549196
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacus_timneh : Psittacus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacus timneh";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacus_timneh";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1549196;
}
