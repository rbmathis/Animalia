namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamias;

/// <summary>
/// Species: Tamias palmeri
/// NCBI TaxId: 123789
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tamias_palmeri : Tamias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tamias palmeri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tamias_palmeri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 123789;
}
