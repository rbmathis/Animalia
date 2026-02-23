namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Maxomys;

/// <summary>
/// Species: Maxomys sp. ASA-2010
/// NCBI TaxId: 907930
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Maxomys_sp_ASA_2010 : Maxomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Maxomys sp. ASA-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Maxomys_sp_ASA_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 907930;
}
