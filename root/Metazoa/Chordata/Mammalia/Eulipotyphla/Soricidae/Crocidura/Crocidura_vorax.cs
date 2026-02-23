namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura vorax
/// NCBI TaxId: 2710923
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_vorax : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura vorax";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_vorax";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2710923;
}
