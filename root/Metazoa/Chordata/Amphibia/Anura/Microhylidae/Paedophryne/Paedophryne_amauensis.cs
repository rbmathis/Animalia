namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Paedophryne;

/// <summary>
/// Species: Paedophryne amauensis
/// NCBI TaxId: 1075810
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paedophryne_amauensis : Paedophryne
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paedophryne amauensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paedophryne_amauensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1075810;
}
