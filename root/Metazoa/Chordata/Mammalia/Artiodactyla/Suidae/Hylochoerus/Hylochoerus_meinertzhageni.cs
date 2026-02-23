namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Hylochoerus;

/// <summary>
/// Species: Hylochoerus meinertzhageni
/// NCBI TaxId: 673354
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylochoerus_meinertzhageni : Hylochoerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylochoerus meinertzhageni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylochoerus_meinertzhageni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 673354;
}
