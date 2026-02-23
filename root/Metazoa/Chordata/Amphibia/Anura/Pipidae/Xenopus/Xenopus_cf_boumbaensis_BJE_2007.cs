namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

/// <summary>
/// Species: Xenopus cf. boumbaensis BJE-2007
/// NCBI TaxId: 434054
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenopus_cf_boumbaensis_BJE_2007 : Xenopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenopus cf. boumbaensis BJE-2007";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenopus_cf_boumbaensis_BJE_2007";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 434054;
}
