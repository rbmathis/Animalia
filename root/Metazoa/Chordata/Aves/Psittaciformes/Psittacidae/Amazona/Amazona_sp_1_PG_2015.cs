namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Amazona;

/// <summary>
/// Species: Amazona sp. 1 PG-2015
/// NCBI TaxId: 1637640
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amazona_sp_1_PG_2015 : Amazona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amazona sp. 1 PG-2015";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amazona_sp_1_PG_2015";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1637640;
}
