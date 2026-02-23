namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Hyelaphus;

/// <summary>
/// Species: Hyelaphus porcinus
/// NCBI TaxId: 2494278
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyelaphus_porcinus : Hyelaphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyelaphus porcinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyelaphus_porcinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2494278;
}
