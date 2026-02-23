namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura pergrisea
/// NCBI TaxId: 3141372
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_pergrisea : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura pergrisea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_pergrisea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3141372;
}
