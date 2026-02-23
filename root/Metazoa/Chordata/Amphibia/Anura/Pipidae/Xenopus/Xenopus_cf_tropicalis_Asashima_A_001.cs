namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

/// <summary>
/// Species: Xenopus cf. tropicalis Asashima-A-001
/// NCBI TaxId: 1589957
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenopus_cf_tropicalis_Asashima_A_001 : Xenopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenopus cf. tropicalis Asashima-A-001";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenopus_cf_tropicalis_Asashima_A_001";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1589957;
}
