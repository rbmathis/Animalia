namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.unclassified_Musteloidea;

/// <summary>
/// Species: Musteloidea sp. EG-2017
/// NCBI TaxId: 1967474
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Musteloidea_sp_EG_2017 : unclassified_Musteloidea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Musteloidea sp. EG-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Musteloidea_sp_EG_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1967474;
}
