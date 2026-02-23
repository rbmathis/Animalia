namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Amazona;

/// <summary>
/// Species: Amazona vinacea
/// NCBI TaxId: 244084
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amazona_vinacea : Amazona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amazona vinacea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amazona_vinacea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 244084;
}
