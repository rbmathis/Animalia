namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Echinotriton;

/// <summary>
/// Species: Echinotriton andersoni
/// NCBI TaxId: 385653
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Echinotriton_andersoni : Echinotriton
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Echinotriton andersoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Echinotriton_andersoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 385653;
}
