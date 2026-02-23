namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Ovis;

/// <summary>
/// Species: Ovis dalli
/// NCBI TaxId: 9943
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ovis_dalli : Ovis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ovis dalli";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ovis_dalli";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9943;
}
