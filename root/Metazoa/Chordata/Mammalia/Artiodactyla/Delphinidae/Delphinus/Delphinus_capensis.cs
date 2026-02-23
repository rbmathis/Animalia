namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Delphinus;

/// <summary>
/// Species: Delphinus capensis
/// NCBI TaxId: 103584
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Delphinus_capensis : Delphinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Delphinus capensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Delphinus_capensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 103584;
}
