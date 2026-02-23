namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Hynobius;

/// <summary>
/// Species: Hynobius lichenatus
/// NCBI TaxId: 324338
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hynobius_lichenatus : Hynobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hynobius lichenatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hynobius_lichenatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 324338;
}
