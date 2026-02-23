namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Desmomys;

/// <summary>
/// Species: Desmomys harringtoni
/// NCBI TaxId: 121587
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Desmomys_harringtoni : Desmomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Desmomys harringtoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Desmomys_harringtoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 121587;
}
