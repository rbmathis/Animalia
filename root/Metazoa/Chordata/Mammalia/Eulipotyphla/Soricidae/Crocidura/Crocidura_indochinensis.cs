namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura indochinensis
/// NCBI TaxId: 876679
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_indochinensis : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura indochinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_indochinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 876679;
}
