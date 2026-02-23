namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Ovis;

/// <summary>
/// Species: Ovis orientalis
/// NCBI TaxId: 469796
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ovis_orientalis : Ovis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ovis orientalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ovis_orientalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 469796;
}
