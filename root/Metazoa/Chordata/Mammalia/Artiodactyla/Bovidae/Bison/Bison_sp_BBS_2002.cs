namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bison;

/// <summary>
/// Species: Bison sp. BBS-2002
/// NCBI TaxId: 213252
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bison_sp_BBS_2002 : Bison
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bison sp. BBS-2002";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bison_sp_BBS_2002";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 213252;
}
