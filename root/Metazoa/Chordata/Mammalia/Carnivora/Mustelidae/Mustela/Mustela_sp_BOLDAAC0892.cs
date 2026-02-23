namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mustela;

/// <summary>
/// Species: Mustela sp. BOLD:AAC0892
/// NCBI TaxId: 1147105
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustela_sp_BOLDAAC0892 : Mustela
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustela sp. BOLD:AAC0892";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustela_sp_BOLDAAC0892";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1147105;
}
