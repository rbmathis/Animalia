namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Ovis;

/// <summary>
/// Species: Ovis sp. LF-2011
/// NCBI TaxId: 1110706
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ovis_sp_LF_2011 : Ovis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ovis sp. LF-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ovis_sp_LF_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1110706;
}
