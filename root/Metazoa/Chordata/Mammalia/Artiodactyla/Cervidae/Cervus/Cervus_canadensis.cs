namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Cervus;

/// <summary>
/// Species: Cervus canadensis
/// NCBI TaxId: 1574408
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cervus_canadensis : Cervus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cervus canadensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cervus_canadensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1574408;
}
