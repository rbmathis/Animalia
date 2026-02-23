namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neodon;

/// <summary>
/// Species: Neodon fuscus
/// NCBI TaxId: 771787
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neodon_fuscus : Neodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neodon fuscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neodon_fuscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 771787;
}
