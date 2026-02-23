namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Cavia;

/// <summary>
/// Species: Cavia magna
/// NCBI TaxId: 297387
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cavia_magna : Cavia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cavia magna";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cavia_magna";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 297387;
}
