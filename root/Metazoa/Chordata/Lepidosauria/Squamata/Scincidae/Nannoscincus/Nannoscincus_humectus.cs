namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Nannoscincus;

/// <summary>
/// Species: Nannoscincus humectus
/// NCBI TaxId: 394157
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nannoscincus_humectus : Nannoscincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nannoscincus humectus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nannoscincus_humectus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 394157;
}
