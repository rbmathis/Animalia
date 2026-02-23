namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla sp. AG-2007
/// NCBI TaxId: 425684
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_sp_AG_2007 : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla sp. AG-2007";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_sp_AG_2007";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 425684;
}
