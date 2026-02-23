namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anas;

/// <summary>
/// Species: Anas sp.
/// NCBI TaxId: 42806
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anas_sp : Anas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anas sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anas_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 42806;
}
