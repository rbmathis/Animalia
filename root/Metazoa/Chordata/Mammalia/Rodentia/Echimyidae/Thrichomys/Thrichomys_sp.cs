namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Thrichomys;

/// <summary>
/// Species: Thrichomys sp.
/// NCBI TaxId: 190822
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thrichomys_sp : Thrichomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thrichomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thrichomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 190822;
}
