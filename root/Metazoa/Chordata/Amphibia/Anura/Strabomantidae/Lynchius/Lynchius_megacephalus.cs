namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Lynchius;

/// <summary>
/// Species: Lynchius megacephalus
/// NCBI TaxId: 2587265
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lynchius_megacephalus : Lynchius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lynchius megacephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lynchius_megacephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2587265;
}
