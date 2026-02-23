namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Berylmys;

/// <summary>
/// Species: Berylmys berdmorei
/// NCBI TaxId: 595394
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Berylmys_berdmorei : Berylmys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Berylmys berdmorei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Berylmys_berdmorei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 595394;
}
