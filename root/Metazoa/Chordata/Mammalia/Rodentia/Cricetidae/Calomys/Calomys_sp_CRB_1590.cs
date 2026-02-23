namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Calomys;

/// <summary>
/// Species: Calomys sp. CRB 1590
/// NCBI TaxId: 245181
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calomys_sp_CRB_1590 : Calomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calomys sp. CRB 1590";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calomys_sp_CRB_1590";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 245181;
}
