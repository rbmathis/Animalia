namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Myliobatis;

/// <summary>
/// Species: Myliobatis californica
/// NCBI TaxId: 319543
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myliobatis_californica : Myliobatis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myliobatis californica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myliobatis_californica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 319543;
}
