namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacus;

/// <summary>
/// Species: Psittacus erithacus
/// NCBI TaxId: 57247
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacus_erithacus : Psittacus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacus erithacus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacus_erithacus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 57247;
}
