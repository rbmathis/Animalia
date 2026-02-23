namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xantusiidae.Lepidophyma;

/// <summary>
/// Species: Lepidophyma sp.
/// NCBI TaxId: 2984885
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepidophyma_sp : Lepidophyma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepidophyma sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepidophyma_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2984885;
}
