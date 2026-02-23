namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Batagur;

/// <summary>
/// Species: Batagur affinis
/// NCBI TaxId: 488792
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Batagur_affinis : Batagur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Batagur affinis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Batagur_affinis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 488792;
}
