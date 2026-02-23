namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Aethomys;

/// <summary>
/// Species: Aethomys chrysophilus
/// NCBI TaxId: 121561
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aethomys_chrysophilus : Aethomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aethomys chrysophilus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aethomys_chrysophilus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 121561;
}
