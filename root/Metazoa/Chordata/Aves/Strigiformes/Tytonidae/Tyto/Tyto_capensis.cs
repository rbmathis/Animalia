namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Tytonidae.Tyto;

/// <summary>
/// Species: Tyto capensis
/// NCBI TaxId: 212794
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tyto_capensis : Tyto
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tyto capensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tyto_capensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 212794;
}
