namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Brotogeris;

/// <summary>
/// Species: Brotogeris jugularis
/// NCBI TaxId: 503983
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brotogeris_jugularis : Brotogeris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brotogeris jugularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brotogeris_jugularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 503983;
}
