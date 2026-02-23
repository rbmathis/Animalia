namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamias;

/// <summary>
/// Species: Tamias speciosus
/// NCBI TaxId: 202006
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tamias_speciosus : Tamias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tamias speciosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tamias_speciosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 202006;
}
