namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylvia;

/// <summary>
/// Species: Sylvia margelanica
/// NCBI TaxId: 1286967
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sylvia_margelanica : Sylvia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sylvia margelanica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sylvia_margelanica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1286967;
}
