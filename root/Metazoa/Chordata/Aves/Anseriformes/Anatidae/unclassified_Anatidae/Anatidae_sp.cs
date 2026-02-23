namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.unclassified_Anatidae;

/// <summary>
/// Species: Anatidae sp.
/// NCBI TaxId: 1867944
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anatidae_sp : unclassified_Anatidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anatidae sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anatidae_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1867944;
}
