namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Cisticola;

/// <summary>
/// Species: Cisticola pipiens
/// NCBI TaxId: 2292718
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cisticola_pipiens : Cisticola
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cisticola pipiens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cisticola_pipiens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2292718;
}
