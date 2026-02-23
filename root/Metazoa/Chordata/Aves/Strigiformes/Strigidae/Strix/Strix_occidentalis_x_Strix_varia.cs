namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Strix;

/// <summary>
/// Species: Strix occidentalis x Strix varia
/// NCBI TaxId: 531389
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Strix_occidentalis_x_Strix_varia : Strix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Strix occidentalis x Strix varia";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Strix_occidentalis_x_Strix_varia";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 531389;
}
