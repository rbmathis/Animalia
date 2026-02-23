namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Grammomys;

/// <summary>
/// Species: Grammomys sp.
/// NCBI TaxId: 121589
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Grammomys_sp : Grammomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Grammomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Grammomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 121589;
}
