namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Oenomys;

/// <summary>
/// Species: Oenomys ornatus
/// NCBI TaxId: 3370445
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oenomys_ornatus : Oenomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oenomys ornatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oenomys_ornatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3370445;
}
