namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Baeolophus;

/// <summary>
/// Species: Baeolophus inornatus
/// NCBI TaxId: 142467
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Baeolophus_inornatus : Baeolophus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Baeolophus inornatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Baeolophus_inornatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 142467;
}
