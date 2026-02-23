namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelodina;

/// <summary>
/// Species: Chelodina colliei
/// NCBI TaxId: 1576368
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelodina_colliei : Chelodina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelodina colliei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelodina_colliei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1576368;
}
