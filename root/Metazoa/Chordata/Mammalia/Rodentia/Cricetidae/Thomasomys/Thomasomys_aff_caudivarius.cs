namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Thomasomys;

/// <summary>
/// Species: Thomasomys aff. caudivarius
/// NCBI TaxId: 3144139
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thomasomys_aff_caudivarius : Thomasomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thomasomys aff. caudivarius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thomasomys_aff_caudivarius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3144139;
}
