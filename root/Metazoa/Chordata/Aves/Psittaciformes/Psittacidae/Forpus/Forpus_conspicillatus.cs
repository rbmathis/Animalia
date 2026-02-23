namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Forpus;

/// <summary>
/// Species: Forpus conspicillatus
/// NCBI TaxId: 1265750
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Forpus_conspicillatus : Forpus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Forpus conspicillatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Forpus_conspicillatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1265750;
}
