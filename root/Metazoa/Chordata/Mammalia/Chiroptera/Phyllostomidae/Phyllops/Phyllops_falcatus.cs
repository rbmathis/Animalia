namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Phyllops;

/// <summary>
/// Species: Phyllops falcatus
/// NCBI TaxId: 270772
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllops_falcatus : Phyllops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllops falcatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllops_falcatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 270772;
}
