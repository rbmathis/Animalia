namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Lontra;

/// <summary>
/// Species: Lontra canadensis
/// NCBI TaxId: 76717
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lontra_canadensis : Lontra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lontra canadensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lontra_canadensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 76717;
}
