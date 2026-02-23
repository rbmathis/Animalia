namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Brotogeris;

/// <summary>
/// Species: Brotogeris versicolurus
/// NCBI TaxId: 178886
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brotogeris_versicolurus : Brotogeris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brotogeris versicolurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brotogeris_versicolurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 178886;
}
