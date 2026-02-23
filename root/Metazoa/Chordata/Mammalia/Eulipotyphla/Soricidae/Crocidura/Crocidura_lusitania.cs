namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura lusitania
/// NCBI TaxId: 214446
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_lusitania : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura lusitania";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_lusitania";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 214446;
}
