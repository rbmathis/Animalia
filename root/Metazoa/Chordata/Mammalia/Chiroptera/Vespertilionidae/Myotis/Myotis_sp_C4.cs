namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis sp. C4
/// NCBI TaxId: 509037
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_sp_C4 : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis sp. C4";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_sp_C4";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 509037;
}
