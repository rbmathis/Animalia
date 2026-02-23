namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura maurisca
/// NCBI TaxId: 214447
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_maurisca : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura maurisca";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_maurisca";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 214447;
}
