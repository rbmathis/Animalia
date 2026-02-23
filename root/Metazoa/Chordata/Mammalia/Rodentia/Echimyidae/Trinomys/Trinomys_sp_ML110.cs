namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Trinomys;

/// <summary>
/// Species: Trinomys sp. ML110
/// NCBI TaxId: 109339
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trinomys_sp_ML110 : Trinomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trinomys sp. ML110";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trinomys_sp_ML110";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 109339;
}
