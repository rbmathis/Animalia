namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pelomys;

/// <summary>
/// Species: Pelomys sp.
/// NCBI TaxId: 1890045
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelomys_sp : Pelomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1890045;
}
