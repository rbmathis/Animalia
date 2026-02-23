namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Ninox;

/// <summary>
/// Species: Ninox japonica
/// NCBI TaxId: 1344560
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ninox_japonica : Ninox
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ninox japonica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ninox_japonica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1344560;
}
