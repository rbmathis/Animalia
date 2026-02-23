namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Batagur;

/// <summary>
/// Species: Batagur borneoensis
/// NCBI TaxId: 904174
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Batagur_borneoensis : Batagur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Batagur borneoensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Batagur_borneoensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904174;
}
