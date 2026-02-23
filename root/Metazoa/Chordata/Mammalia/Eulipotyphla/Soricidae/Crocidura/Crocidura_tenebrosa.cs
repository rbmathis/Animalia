namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura tenebrosa
/// NCBI TaxId: 2873343
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_tenebrosa : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura tenebrosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_tenebrosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2873343;
}
