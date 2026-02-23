namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Picus;

/// <summary>
/// Species: Picus canus
/// NCBI TaxId: 301969
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Picus_canus : Picus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Picus canus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Picus_canus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 301969;
}
