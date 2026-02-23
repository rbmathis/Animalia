namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis sp. 2 RJL-2012
/// NCBI TaxId: 1239434
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_sp_2_RJL_2012 : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis sp. 2 RJL-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_sp_2_RJL_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1239434;
}
