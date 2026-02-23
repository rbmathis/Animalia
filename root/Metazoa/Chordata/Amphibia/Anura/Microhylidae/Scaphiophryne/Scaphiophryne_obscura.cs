namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Scaphiophryne;

/// <summary>
/// Species: Scaphiophryne obscura
/// NCBI TaxId: 2778651
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scaphiophryne_obscura : Scaphiophryne
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scaphiophryne obscura";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scaphiophryne_obscura";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2778651;
}
