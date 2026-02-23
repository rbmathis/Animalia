namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Pelodiscus;

/// <summary>
/// Species: Pelodiscus huangshanensis
/// NCBI TaxId: 3022035
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelodiscus_huangshanensis : Pelodiscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelodiscus huangshanensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelodiscus_huangshanensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3022035;
}
