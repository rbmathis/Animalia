namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Suncus;

/// <summary>
/// Species: Suncus stoliczkanus
/// NCBI TaxId: 268751
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Suncus_stoliczkanus : Suncus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Suncus stoliczkanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Suncus_stoliczkanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 268751;
}
