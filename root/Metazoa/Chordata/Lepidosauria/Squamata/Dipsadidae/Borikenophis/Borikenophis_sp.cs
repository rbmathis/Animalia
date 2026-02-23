namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Borikenophis;

/// <summary>
/// Species: Borikenophis sp.
/// NCBI TaxId: 2358242
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Borikenophis_sp : Borikenophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Borikenophis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Borikenophis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2358242;
}
