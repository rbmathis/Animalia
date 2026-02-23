namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Leptomys;

/// <summary>
/// Species: Leptomys elegans
/// NCBI TaxId: 442572
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptomys_elegans : Leptomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptomys elegans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptomys_elegans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 442572;
}
