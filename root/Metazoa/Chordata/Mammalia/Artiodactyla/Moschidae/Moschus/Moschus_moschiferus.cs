namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Moschidae.Moschus;

/// <summary>
/// Species: Moschus moschiferus
/// NCBI TaxId: 68415
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Moschus_moschiferus : Moschus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Moschus moschiferus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Moschus_moschiferus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 68415;
}
