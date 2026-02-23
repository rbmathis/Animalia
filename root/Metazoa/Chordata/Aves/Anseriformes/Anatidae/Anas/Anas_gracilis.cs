namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anas;

/// <summary>
/// Species: Anas gracilis
/// NCBI TaxId: 45630
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anas_gracilis : Anas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anas gracilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anas_gracilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 45630;
}
