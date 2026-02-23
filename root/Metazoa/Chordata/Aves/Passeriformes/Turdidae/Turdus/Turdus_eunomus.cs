namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Turdus;

/// <summary>
/// Species: Turdus eunomus
/// NCBI TaxId: 1562130
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Turdus_eunomus : Turdus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Turdus eunomus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Turdus_eunomus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1562130;
}
