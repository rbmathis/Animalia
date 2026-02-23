namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Rhinella;

/// <summary>
/// Species: Rhinella fissipes
/// NCBI TaxId: 2826089
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinella_fissipes : Rhinella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinella fissipes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinella_fissipes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2826089;
}
