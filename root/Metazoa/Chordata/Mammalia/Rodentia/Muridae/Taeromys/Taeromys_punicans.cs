namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Taeromys;

/// <summary>
/// Species: Taeromys punicans
/// NCBI TaxId: 2716768
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Taeromys_punicans : Taeromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Taeromys punicans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Taeromys_punicans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2716768;
}
