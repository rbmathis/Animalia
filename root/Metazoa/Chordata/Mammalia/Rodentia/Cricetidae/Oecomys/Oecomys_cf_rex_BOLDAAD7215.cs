namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

/// <summary>
/// Species: Oecomys cf. rex BOLD:AAD7215
/// NCBI TaxId: 1003881
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oecomys_cf_rex_BOLDAAD7215 : Oecomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oecomys cf. rex BOLD:AAD7215";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oecomys_cf_rex_BOLDAAD7215";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1003881;
}
