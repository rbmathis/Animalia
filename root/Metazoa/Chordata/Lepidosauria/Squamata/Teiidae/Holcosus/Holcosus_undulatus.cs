namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Holcosus;

/// <summary>
/// Species: Holcosus undulatus
/// NCBI TaxId: 171128
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Holcosus_undulatus : Holcosus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Holcosus undulatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Holcosus_undulatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 171128;
}
