namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae.Torpedo;

/// <summary>
/// Species: Torpedo sp. A KKB-2014
/// NCBI TaxId: 1455695
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Torpedo_sp_A_KKB_2014 : Torpedo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Torpedo sp. A KKB-2014";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Torpedo_sp_A_KKB_2014";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1455695;
}
