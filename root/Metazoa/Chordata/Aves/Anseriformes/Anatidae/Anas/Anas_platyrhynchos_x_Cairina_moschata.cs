namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anas;

/// <summary>
/// Species: Anas platyrhynchos x Cairina moschata
/// NCBI TaxId: 8841
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anas_platyrhynchos_x_Cairina_moschata : Anas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anas platyrhynchos x Cairina moschata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anas_platyrhynchos_x_Cairina_moschata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8841;
}
