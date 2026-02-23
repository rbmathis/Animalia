namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Antechinus;

/// <summary>
/// Species: Antechinus sp.
/// NCBI TaxId: 71387
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Antechinus_sp : Antechinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Antechinus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Antechinus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 71387;
}
