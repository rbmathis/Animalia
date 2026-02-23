namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura parvipes
/// NCBI TaxId: 363229
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_parvipes : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura parvipes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_parvipes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 363229;
}
