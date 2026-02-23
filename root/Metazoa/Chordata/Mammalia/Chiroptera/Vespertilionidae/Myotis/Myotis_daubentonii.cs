namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis daubentonii
/// NCBI TaxId: 98922
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_daubentonii : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis daubentonii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_daubentonii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 98922;
}
