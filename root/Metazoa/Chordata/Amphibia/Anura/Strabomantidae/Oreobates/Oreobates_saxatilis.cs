namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Oreobates;

/// <summary>
/// Species: Oreobates saxatilis
/// NCBI TaxId: 491133
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oreobates_saxatilis : Oreobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oreobates saxatilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oreobates_saxatilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 491133;
}
