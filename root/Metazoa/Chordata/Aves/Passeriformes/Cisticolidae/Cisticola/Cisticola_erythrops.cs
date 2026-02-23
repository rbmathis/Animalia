namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Cisticola;

/// <summary>
/// Species: Cisticola erythrops
/// NCBI TaxId: 1200311
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cisticola_erythrops : Cisticola
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cisticola erythrops";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cisticola_erythrops";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1200311;
}
