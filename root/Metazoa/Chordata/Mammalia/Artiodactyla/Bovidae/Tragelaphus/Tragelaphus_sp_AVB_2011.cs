namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Tragelaphus;

/// <summary>
/// Species: Tragelaphus sp. AVB-2011
/// NCBI TaxId: 1002718
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tragelaphus_sp_AVB_2011 : Tragelaphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tragelaphus sp. AVB-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tragelaphus_sp_AVB_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1002718;
}
