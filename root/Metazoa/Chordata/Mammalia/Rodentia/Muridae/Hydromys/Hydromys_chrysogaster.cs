namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hydromys;

/// <summary>
/// Species: Hydromys chrysogaster
/// NCBI TaxId: 160448
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hydromys_chrysogaster : Hydromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hydromys chrysogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hydromys_chrysogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 160448;
}
