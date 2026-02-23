namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus hydruntinus
/// NCBI TaxId: 379504
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_hydruntinus : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus hydruntinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_hydruntinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 379504;
}
