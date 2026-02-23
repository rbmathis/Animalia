namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura eburnea
/// NCBI TaxId: 1627869
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_eburnea : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura eburnea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_eburnea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1627869;
}
