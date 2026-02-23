namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacara;

/// <summary>
/// Species: Psittacara brevipes
/// NCBI TaxId: 867385
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacara_brevipes : Psittacara
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacara brevipes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacara_brevipes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 867385;
}
