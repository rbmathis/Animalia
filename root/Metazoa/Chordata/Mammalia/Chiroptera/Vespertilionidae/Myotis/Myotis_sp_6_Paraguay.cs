namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis sp. 6 Paraguay
/// NCBI TaxId: 1239999
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_sp_6_Paraguay : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis sp. 6 Paraguay";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_sp_6_Paraguay";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1239999;
}
