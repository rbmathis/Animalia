namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Hyaenidae.Crocuta;

/// <summary>
/// Species: Crocuta crocuta
/// NCBI TaxId: 9678
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocuta_crocuta : Crocuta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocuta crocuta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocuta_crocuta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9678;
}
