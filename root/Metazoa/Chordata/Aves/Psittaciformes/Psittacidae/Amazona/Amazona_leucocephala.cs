namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Amazona;

/// <summary>
/// Species: Amazona leucocephala
/// NCBI TaxId: 241562
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amazona_leucocephala : Amazona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amazona leucocephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amazona_leucocephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 241562;
}
