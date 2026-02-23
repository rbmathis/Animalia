namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Chironius;

/// <summary>
/// Species: Chironius flavopictus
/// NCBI TaxId: 2478829
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chironius_flavopictus : Chironius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chironius flavopictus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chironius_flavopictus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2478829;
}
