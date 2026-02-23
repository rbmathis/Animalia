namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

/// <summary>
/// Species: Cervidae sp. Jeju
/// NCBI TaxId: 320556
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cervidae_sp_Jeju : Cervidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cervidae sp. Jeju";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cervidae_sp_Jeju";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 320556;
}
