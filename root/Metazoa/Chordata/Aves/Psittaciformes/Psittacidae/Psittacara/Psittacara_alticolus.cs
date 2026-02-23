namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacara;

/// <summary>
/// Species: Psittacara alticolus
/// NCBI TaxId: 2822205
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacara_alticolus : Psittacara
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacara alticolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacara_alticolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2822205;
}
