namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oryzomys;

/// <summary>
/// Species: Oryzomys sp. Itabuna
/// NCBI TaxId: 132254
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oryzomys_sp_Itabuna : Oryzomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oryzomys sp. Itabuna";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oryzomys_sp_Itabuna";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 132254;
}
