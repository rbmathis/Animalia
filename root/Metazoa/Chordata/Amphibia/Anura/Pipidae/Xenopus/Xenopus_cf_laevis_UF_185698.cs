namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

/// <summary>
/// Species: Xenopus cf. laevis UF 185698
/// NCBI TaxId: 2664373
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenopus_cf_laevis_UF_185698 : Xenopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenopus cf. laevis UF 185698";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenopus_cf_laevis_UF_185698";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2664373;
}
