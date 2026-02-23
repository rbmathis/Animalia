namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Lepus;

/// <summary>
/// Species: Lepus californicus
/// NCBI TaxId: 48087
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepus_californicus : Lepus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepus californicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepus_californicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 48087;
}
