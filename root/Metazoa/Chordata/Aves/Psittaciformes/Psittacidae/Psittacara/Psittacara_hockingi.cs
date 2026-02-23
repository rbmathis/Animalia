namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacara;

/// <summary>
/// Species: Psittacara hockingi
/// NCBI TaxId: 2822442
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacara_hockingi : Psittacara
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacara hockingi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacara_hockingi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2822442;
}
