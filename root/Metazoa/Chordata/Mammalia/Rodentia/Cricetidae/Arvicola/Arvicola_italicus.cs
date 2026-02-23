namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Arvicola;

/// <summary>
/// Species: Arvicola italicus
/// NCBI TaxId: 3037430
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Arvicola_italicus : Arvicola
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Arvicola italicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Arvicola_italicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3037430;
}
