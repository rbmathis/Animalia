namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Moschidae.Moschus;

/// <summary>
/// Species: Moschus sp. RWM-2011
/// NCBI TaxId: 1088704
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Moschus_sp_RWM_2011 : Moschus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Moschus sp. RWM-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Moschus_sp_RWM_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1088704;
}
