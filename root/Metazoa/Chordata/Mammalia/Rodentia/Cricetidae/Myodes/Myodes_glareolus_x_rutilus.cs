namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Myodes;

/// <summary>
/// Species: Myodes glareolus x rutilus
/// NCBI TaxId: 1160806
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myodes_glareolus_x_rutilus : Myodes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myodes glareolus x rutilus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myodes_glareolus_x_rutilus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1160806;
}
