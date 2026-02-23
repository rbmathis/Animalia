namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamias;

/// <summary>
/// Species: Tamias rufus
/// NCBI TaxId: 123793
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tamias_rufus : Tamias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tamias rufus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tamias_rufus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 123793;
}
