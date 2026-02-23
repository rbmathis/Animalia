namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.unclassified_Phyllostomidae;

/// <summary>
/// Species: Phyllostomidae sp.
/// NCBI TaxId: 3242307
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllostomidae_sp : unclassified_Phyllostomidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllostomidae sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllostomidae_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3242307;
}
