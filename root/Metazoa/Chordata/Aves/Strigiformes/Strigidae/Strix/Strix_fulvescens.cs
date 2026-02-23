namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Strix;

/// <summary>
/// Species: Strix fulvescens
/// NCBI TaxId: 1053994
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Strix_fulvescens : Strix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Strix fulvescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Strix_fulvescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1053994;
}
