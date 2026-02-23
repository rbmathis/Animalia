namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Holcosus;

/// <summary>
/// Species: Holcosus quadrilineatus
/// NCBI TaxId: 171127
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Holcosus_quadrilineatus : Holcosus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Holcosus quadrilineatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Holcosus_quadrilineatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 171127;
}
