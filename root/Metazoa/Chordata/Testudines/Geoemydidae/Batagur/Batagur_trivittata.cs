namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Batagur;

/// <summary>
/// Species: Batagur trivittata
/// NCBI TaxId: 686919
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Batagur_trivittata : Batagur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Batagur trivittata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Batagur_trivittata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 686919;
}
