namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Arvicola;

/// <summary>
/// Species: Arvicola sapidus
/// NCBI TaxId: 88454
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Arvicola_sapidus : Arvicola
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Arvicola sapidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Arvicola_sapidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 88454;
}
