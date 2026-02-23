namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Cephalophus;

/// <summary>
/// Species: Cephalophus sp.
/// NCBI TaxId: 3064502
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cephalophus_sp : Cephalophus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cephalophus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cephalophus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3064502;
}
