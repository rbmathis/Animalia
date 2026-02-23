namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Trichomycterus;

/// <summary>
/// Species: Trichomycterus sp.
/// NCBI TaxId: 36720
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trichomycterus_sp : Trichomycterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trichomycterus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trichomycterus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 36720;
}
