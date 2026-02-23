namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Batagur;

/// <summary>
/// Species: Batagur sp. AA1016
/// NCBI TaxId: 623718
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Batagur_sp_AA1016 : Batagur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Batagur sp. AA1016";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Batagur_sp_AA1016";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 623718;
}
