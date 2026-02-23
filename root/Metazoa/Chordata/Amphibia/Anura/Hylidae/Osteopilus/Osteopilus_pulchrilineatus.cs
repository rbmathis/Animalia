namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Osteopilus;

/// <summary>
/// Species: Osteopilus pulchrilineatus
/// NCBI TaxId: 317343
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Osteopilus_pulchrilineatus : Osteopilus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Osteopilus pulchrilineatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Osteopilus_pulchrilineatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 317343;
}
