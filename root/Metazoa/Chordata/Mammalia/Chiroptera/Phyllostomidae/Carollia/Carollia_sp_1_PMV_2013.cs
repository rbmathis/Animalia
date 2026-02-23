namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Carollia;

/// <summary>
/// Species: Carollia sp. 1 PMV-2013
/// NCBI TaxId: 1380313
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carollia_sp_1_PMV_2013 : Carollia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carollia sp. 1 PMV-2013";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carollia_sp_1_PMV_2013";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1380313;
}
