namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Myliobatis;

/// <summary>
/// Species: Myliobatis longirostris
/// NCBI TaxId: 86358
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myliobatis_longirostris : Myliobatis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myliobatis longirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myliobatis_longirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 86358;
}
