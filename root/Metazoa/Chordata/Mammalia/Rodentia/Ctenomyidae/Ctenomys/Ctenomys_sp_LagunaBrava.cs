namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenomyidae.Ctenomys;

/// <summary>
/// Species: Ctenomys sp. LagunaBrava
/// NCBI TaxId: 2942187
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ctenomys_sp_LagunaBrava : Ctenomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ctenomys sp. LagunaBrava";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ctenomys_sp_LagunaBrava";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2942187;
}
