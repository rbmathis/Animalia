namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylvietta;

/// <summary>
/// Species: Sylvietta rufescens
/// NCBI TaxId: 405088
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sylvietta_rufescens : Sylvietta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sylvietta rufescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sylvietta_rufescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 405088;
}
