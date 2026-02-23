namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Pollachius;

/// <summary>
/// Species: Pollachius environmental sample
/// NCBI TaxId: 1814141
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pollachius_environmental_sample : Pollachius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pollachius environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pollachius_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1814141;
}
