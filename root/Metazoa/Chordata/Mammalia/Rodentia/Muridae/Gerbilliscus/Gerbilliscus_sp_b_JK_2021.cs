namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gerbilliscus;

/// <summary>
/// Species: Gerbilliscus sp. b JK-2021
/// NCBI TaxId: 2819589
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gerbilliscus_sp_b_JK_2021 : Gerbilliscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gerbilliscus sp. b JK-2021";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gerbilliscus_sp_b_JK_2021";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2819589;
}
