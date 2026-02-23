namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Myliobatis;

/// <summary>
/// Species: Myliobatis aquila
/// NCBI TaxId: 990611
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myliobatis_aquila : Myliobatis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myliobatis aquila";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myliobatis_aquila";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 990611;
}
