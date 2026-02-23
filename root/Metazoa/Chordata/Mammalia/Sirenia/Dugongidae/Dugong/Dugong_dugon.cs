namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Sirenia.Dugongidae.Dugong;

/// <summary>
/// Species: Dugong dugon
/// NCBI TaxId: 29137
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dugong_dugon : Dugong
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dugong dugon";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dugong_dugon";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 29137;
}
