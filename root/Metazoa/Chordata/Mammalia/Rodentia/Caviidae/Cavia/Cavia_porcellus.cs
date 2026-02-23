namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Cavia;

/// <summary>
/// Species: Cavia porcellus
/// NCBI TaxId: 10141
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cavia_porcellus : Cavia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cavia porcellus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cavia_porcellus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10141;
}
