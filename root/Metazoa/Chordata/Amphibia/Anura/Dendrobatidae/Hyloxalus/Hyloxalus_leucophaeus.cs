namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Hyloxalus;

/// <summary>
/// Species: Hyloxalus leucophaeus
/// NCBI TaxId: 507636
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyloxalus_leucophaeus : Hyloxalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyloxalus leucophaeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyloxalus_leucophaeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 507636;
}
