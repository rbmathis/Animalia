namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Hynobius;

/// <summary>
/// Species: Hynobius sp.
/// NCBI TaxId: 3074224
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hynobius_sp : Hynobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hynobius sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hynobius_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3074224;
}
