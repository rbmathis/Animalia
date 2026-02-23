namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Ovis;

/// <summary>
/// Species: Ovis canadensis
/// NCBI TaxId: 37174
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ovis_canadensis : Ovis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ovis canadensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ovis_canadensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37174;
}
