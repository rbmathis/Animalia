namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.unclassified_Chiroptera;

/// <summary>
/// Species: Chiroptera sp. BOLD:AAO1832
/// NCBI TaxId: 974339
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chiroptera_sp_BOLDAAO1832 : unclassified_Chiroptera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chiroptera sp. BOLD:AAO1832";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chiroptera_sp_BOLDAAO1832";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 974339;
}
