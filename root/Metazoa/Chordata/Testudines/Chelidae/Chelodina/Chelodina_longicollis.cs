namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelodina;

/// <summary>
/// Species: Chelodina longicollis
/// NCBI TaxId: 44491
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelodina_longicollis : Chelodina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelodina longicollis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelodina_longicollis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 44491;
}
