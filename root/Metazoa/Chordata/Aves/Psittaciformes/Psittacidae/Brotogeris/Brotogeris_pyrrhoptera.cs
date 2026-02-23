namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Brotogeris;

/// <summary>
/// Species: Brotogeris pyrrhoptera
/// NCBI TaxId: 176018
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brotogeris_pyrrhoptera : Brotogeris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brotogeris pyrrhoptera";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brotogeris_pyrrhoptera";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 176018;
}
