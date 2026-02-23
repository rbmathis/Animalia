namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Amazona;

/// <summary>
/// Species: Amazona sp. TEM-2007
/// NCBI TaxId: 468613
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amazona_sp_TEM_2007 : Amazona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amazona sp. TEM-2007";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amazona_sp_TEM_2007";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 468613;
}
