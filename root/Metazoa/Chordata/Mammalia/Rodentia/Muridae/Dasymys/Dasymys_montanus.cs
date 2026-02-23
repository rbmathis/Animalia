namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Dasymys;

/// <summary>
/// Species: Dasymys montanus
/// NCBI TaxId: 3148838
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dasymys_montanus : Dasymys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dasymys montanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dasymys_montanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3148838;
}
