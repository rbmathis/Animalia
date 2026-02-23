namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura muricauda
/// NCBI TaxId: 148975
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_muricauda : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura muricauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_muricauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 148975;
}
