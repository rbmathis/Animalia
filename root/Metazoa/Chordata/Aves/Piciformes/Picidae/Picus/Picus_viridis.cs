namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Picus;

/// <summary>
/// Species: Picus viridis
/// NCBI TaxId: 100825
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Picus_viridis : Picus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Picus viridis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Picus_viridis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100825;
}
