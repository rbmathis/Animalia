namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Sommeromys;

/// <summary>
/// Species: Sommeromys macrorhinos
/// NCBI TaxId: 1795471
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sommeromys_macrorhinos : Sommeromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sommeromys macrorhinos";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sommeromys_macrorhinos";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1795471;
}
