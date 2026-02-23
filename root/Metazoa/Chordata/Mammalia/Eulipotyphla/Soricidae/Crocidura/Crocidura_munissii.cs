namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura munissii
/// NCBI TaxId: 1649346
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_munissii : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura munissii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_munissii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1649346;
}
