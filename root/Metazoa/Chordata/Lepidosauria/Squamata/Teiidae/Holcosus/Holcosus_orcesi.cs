namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Holcosus;

/// <summary>
/// Species: Holcosus orcesi
/// NCBI TaxId: 3148194
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Holcosus_orcesi : Holcosus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Holcosus orcesi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Holcosus_orcesi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3148194;
}
