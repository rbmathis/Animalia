namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Strix;

/// <summary>
/// Species: Strix woodfordii
/// NCBI TaxId: 111824
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Strix_woodfordii : Strix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Strix woodfordii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Strix_woodfordii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 111824;
}
