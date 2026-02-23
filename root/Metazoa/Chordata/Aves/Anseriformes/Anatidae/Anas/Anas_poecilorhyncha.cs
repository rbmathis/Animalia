namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anas;

/// <summary>
/// Species: Anas poecilorhyncha
/// NCBI TaxId: 75854
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anas_poecilorhyncha : Anas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anas poecilorhyncha";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anas_poecilorhyncha";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75854;
}
