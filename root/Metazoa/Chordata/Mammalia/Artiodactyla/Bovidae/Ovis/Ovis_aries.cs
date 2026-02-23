namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Ovis;

/// <summary>
/// Species: Ovis aries
/// NCBI TaxId: 9940
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ovis_aries : Ovis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ovis aries";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ovis_aries";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9940;
}
