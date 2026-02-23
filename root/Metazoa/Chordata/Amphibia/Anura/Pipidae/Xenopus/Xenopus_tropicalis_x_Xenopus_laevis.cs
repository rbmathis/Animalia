namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

/// <summary>
/// Species: Xenopus tropicalis x Xenopus laevis
/// NCBI TaxId: 1925338
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenopus_tropicalis_x_Xenopus_laevis : Xenopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenopus tropicalis x Xenopus laevis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenopus_tropicalis_x_Xenopus_laevis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1925338;
}
