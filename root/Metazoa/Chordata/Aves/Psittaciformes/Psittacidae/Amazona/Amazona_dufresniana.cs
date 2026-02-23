namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Amazona;

/// <summary>
/// Species: Amazona dufresniana
/// NCBI TaxId: 241570
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amazona_dufresniana : Amazona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amazona dufresniana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amazona_dufresniana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 241570;
}
