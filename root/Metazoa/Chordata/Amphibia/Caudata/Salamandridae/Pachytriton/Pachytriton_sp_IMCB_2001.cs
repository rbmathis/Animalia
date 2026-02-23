namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Pachytriton;

/// <summary>
/// Species: Pachytriton sp. IMCB-2001
/// NCBI TaxId: 157709
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachytriton_sp_IMCB_2001 : Pachytriton
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachytriton sp. IMCB-2001";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachytriton_sp_IMCB_2001";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 157709;
}
