namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Maxomys;

/// <summary>
/// Species: Maxomys hellwaldii
/// NCBI TaxId: 472711
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Maxomys_hellwaldii : Maxomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Maxomys hellwaldii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Maxomys_hellwaldii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 472711;
}
