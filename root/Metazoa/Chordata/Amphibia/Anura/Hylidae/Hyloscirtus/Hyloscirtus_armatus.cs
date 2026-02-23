namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyloscirtus;

/// <summary>
/// Species: Hyloscirtus armatus
/// NCBI TaxId: 279987
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyloscirtus_armatus : Hyloscirtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyloscirtus armatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyloscirtus_armatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 279987;
}
