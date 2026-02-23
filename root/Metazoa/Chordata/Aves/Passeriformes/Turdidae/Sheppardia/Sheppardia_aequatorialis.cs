namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Sheppardia;

/// <summary>
/// Species: Sheppardia aequatorialis
/// NCBI TaxId: 141888
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sheppardia_aequatorialis : Sheppardia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sheppardia aequatorialis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sheppardia_aequatorialis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 141888;
}
