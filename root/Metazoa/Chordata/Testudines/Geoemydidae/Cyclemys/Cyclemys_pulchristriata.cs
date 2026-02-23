namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cyclemys;

/// <summary>
/// Species: Cyclemys pulchristriata
/// NCBI TaxId: 378291
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyclemys_pulchristriata : Cyclemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyclemys pulchristriata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyclemys_pulchristriata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 378291;
}
