namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Berylmys;

/// <summary>
/// Species: Berylmys manipulus
/// NCBI TaxId: 1520771
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Berylmys_manipulus : Berylmys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Berylmys manipulus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Berylmys_manipulus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1520771;
}
