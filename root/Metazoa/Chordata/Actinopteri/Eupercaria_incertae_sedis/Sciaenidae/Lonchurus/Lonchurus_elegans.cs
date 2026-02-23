namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Lonchurus;

/// <summary>
/// Species: Lonchurus elegans
/// NCBI TaxId: 3357121
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lonchurus_elegans : Lonchurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lonchurus elegans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lonchurus_elegans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3357121;
}
