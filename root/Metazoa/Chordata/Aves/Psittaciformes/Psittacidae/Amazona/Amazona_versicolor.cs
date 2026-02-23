namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Amazona;

/// <summary>
/// Species: Amazona versicolor
/// NCBI TaxId: 241584
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amazona_versicolor : Amazona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amazona versicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amazona_versicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 241584;
}
