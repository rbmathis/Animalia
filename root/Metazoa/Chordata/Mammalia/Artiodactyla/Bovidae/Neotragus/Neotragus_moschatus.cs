namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Neotragus;

/// <summary>
/// Species: Neotragus moschatus
/// NCBI TaxId: 66442
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neotragus_moschatus : Neotragus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neotragus moschatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neotragus_moschatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 66442;
}
