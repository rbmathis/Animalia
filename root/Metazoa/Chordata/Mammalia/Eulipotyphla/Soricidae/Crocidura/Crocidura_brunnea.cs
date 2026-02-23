namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura brunnea
/// NCBI TaxId: 61087
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_brunnea : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura brunnea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_brunnea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61087;
}
