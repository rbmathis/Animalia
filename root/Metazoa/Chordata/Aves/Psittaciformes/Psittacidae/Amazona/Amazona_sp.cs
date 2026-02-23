namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Amazona;

/// <summary>
/// Species: Amazona sp.
/// NCBI TaxId: 1661781
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amazona_sp : Amazona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amazona sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amazona_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1661781;
}
