namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Pheucticus;

/// <summary>
/// Species: Pheucticus chrysogaster
/// NCBI TaxId: 1622137
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pheucticus_chrysogaster : Pheucticus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pheucticus chrysogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pheucticus_chrysogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1622137;
}
