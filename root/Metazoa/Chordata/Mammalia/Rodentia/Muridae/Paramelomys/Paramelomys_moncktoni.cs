namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Paramelomys;

/// <summary>
/// Species: Paramelomys moncktoni
/// NCBI TaxId: 1078247
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paramelomys_moncktoni : Paramelomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paramelomys moncktoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paramelomys_moncktoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1078247;
}
