namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Ovis;

/// <summary>
/// Species: Ovis ammon
/// NCBI TaxId: 30527
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ovis_ammon : Ovis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ovis ammon";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ovis_ammon";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30527;
}
