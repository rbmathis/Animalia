namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Taurotragus;

/// <summary>
/// Species: Taurotragus derbianus
/// NCBI TaxId: 303930
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Taurotragus_derbianus : Taurotragus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Taurotragus derbianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Taurotragus_derbianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 303930;
}
