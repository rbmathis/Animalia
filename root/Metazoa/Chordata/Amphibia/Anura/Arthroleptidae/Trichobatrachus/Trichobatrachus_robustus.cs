namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Trichobatrachus;

/// <summary>
/// Species: Trichobatrachus robustus
/// NCBI TaxId: 111096
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trichobatrachus_robustus : Trichobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trichobatrachus robustus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trichobatrachus_robustus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 111096;
}
