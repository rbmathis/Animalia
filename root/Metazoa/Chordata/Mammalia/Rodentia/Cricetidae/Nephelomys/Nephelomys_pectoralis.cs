namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Nephelomys;

/// <summary>
/// Species: Nephelomys pectoralis
/// NCBI TaxId: 3098846
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nephelomys_pectoralis : Nephelomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nephelomys pectoralis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nephelomys_pectoralis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3098846;
}
