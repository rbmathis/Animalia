namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Paramelomys;

/// <summary>
/// Species: Paramelomys lorentzii
/// NCBI TaxId: 491863
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paramelomys_lorentzii : Paramelomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paramelomys lorentzii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paramelomys_lorentzii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 491863;
}
