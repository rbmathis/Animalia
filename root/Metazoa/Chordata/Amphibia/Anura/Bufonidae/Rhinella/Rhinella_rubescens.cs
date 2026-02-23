namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Rhinella;

/// <summary>
/// Species: Rhinella rubescens
/// NCBI TaxId: 752686
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinella_rubescens : Rhinella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinella rubescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinella_rubescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 752686;
}
