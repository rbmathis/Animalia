namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Alopochen;

/// <summary>
/// Species: Alopochen aegyptiaca
/// NCBI TaxId: 30382
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alopochen_aegyptiaca : Alopochen
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alopochen aegyptiaca";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alopochen_aegyptiaca";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30382;
}
