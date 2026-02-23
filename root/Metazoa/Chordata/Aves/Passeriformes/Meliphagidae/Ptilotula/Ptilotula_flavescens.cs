namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Ptilotula;

/// <summary>
/// Species: Ptilotula flavescens
/// NCBI TaxId: 670926
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ptilotula_flavescens : Ptilotula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ptilotula flavescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ptilotula_flavescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 670926;
}
