namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Mesomys;

/// <summary>
/// Species: Mesomys sp.
/// NCBI TaxId: 30628
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesomys_sp : Mesomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30628;
}
