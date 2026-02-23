namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Taeromys;

/// <summary>
/// Species: Taeromys hamatus
/// NCBI TaxId: 3148832
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Taeromys_hamatus : Taeromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Taeromys hamatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Taeromys_hamatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3148832;
}
