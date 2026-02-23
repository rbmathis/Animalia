namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Acomys;

/// <summary>
/// Species: Acomys cf. cineraceus
/// NCBI TaxId: 1890046
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acomys_cf_cineraceus : Acomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acomys cf. cineraceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acomys_cf_cineraceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1890046;
}
