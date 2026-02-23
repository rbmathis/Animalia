namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Holcosus;

/// <summary>
/// Species: Holcosus parvus
/// NCBI TaxId: 1735236
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Holcosus_parvus : Holcosus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Holcosus parvus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Holcosus_parvus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1735236;
}
