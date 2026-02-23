namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelodina;

/// <summary>
/// Species: Chelodina parkeri
/// NCBI TaxId: 571342
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelodina_parkeri : Chelodina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelodina parkeri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelodina_parkeri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 571342;
}
