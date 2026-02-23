namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Strix;

/// <summary>
/// Species: Strix sp.
/// NCBI TaxId: 2878431
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Strix_sp : Strix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Strix sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Strix_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2878431;
}
