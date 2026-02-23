namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Pheucticus;

/// <summary>
/// Species: Pheucticus ludovicianus
/// NCBI TaxId: 135444
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pheucticus_ludovicianus : Pheucticus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pheucticus ludovicianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pheucticus_ludovicianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 135444;
}
