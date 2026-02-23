namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Scotonycteris;

/// <summary>
/// Species: Scotonycteris occidentalis
/// NCBI TaxId: 1609904
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scotonycteris_occidentalis : Scotonycteris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scotonycteris occidentalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scotonycteris_occidentalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1609904;
}
