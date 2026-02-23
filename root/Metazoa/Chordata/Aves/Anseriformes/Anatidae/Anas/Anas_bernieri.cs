namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anas;

/// <summary>
/// Species: Anas bernieri
/// NCBI TaxId: 75835
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anas_bernieri : Anas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anas bernieri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anas_bernieri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75835;
}
