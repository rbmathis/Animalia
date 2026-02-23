namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Thomasomys;

/// <summary>
/// Species: Thomasomys caudivarius
/// NCBI TaxId: 411605
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thomasomys_caudivarius : Thomasomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thomasomys caudivarius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thomasomys_caudivarius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 411605;
}
