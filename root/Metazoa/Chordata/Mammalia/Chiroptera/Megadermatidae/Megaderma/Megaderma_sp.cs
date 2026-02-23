namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Megadermatidae.Megaderma;

/// <summary>
/// Species: Megaderma sp.
/// NCBI TaxId: 3242303
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Megaderma_sp : Megaderma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Megaderma sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Megaderma_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3242303;
}
