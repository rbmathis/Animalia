namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lamottemys;

/// <summary>
/// Species: Lamottemys okuensis
/// NCBI TaxId: 1261106
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lamottemys_okuensis : Lamottemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lamottemys okuensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lamottemys_okuensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1261106;
}
