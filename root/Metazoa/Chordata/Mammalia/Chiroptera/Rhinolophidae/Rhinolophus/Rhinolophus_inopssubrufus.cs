namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinolophidae.Rhinolophus;

/// <summary>
/// Species: Rhinolophus inops/subrufus
/// NCBI TaxId: 1078825
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinolophus_inopssubrufus : Rhinolophus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinolophus inops/subrufus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinolophus_inopssubrufus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1078825;
}
