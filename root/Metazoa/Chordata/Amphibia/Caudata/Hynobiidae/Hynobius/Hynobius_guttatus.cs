namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Hynobius;

/// <summary>
/// Species: Hynobius guttatus
/// NCBI TaxId: 2605976
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hynobius_guttatus : Hynobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hynobius guttatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hynobius_guttatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2605976;
}
