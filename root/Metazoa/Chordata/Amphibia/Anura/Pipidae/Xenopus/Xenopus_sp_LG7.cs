namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

/// <summary>
/// Species: Xenopus sp. LG7
/// NCBI TaxId: 443182
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenopus_sp_LG7 : Xenopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenopus sp. LG7";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenopus_sp_LG7";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 443182;
}
