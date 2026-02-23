namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Arvicola;

/// <summary>
/// Species: Arvicola persicus
/// NCBI TaxId: 2654748
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Arvicola_persicus : Arvicola
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Arvicola persicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Arvicola_persicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2654748;
}
