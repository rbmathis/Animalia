namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elusor;

/// <summary>
/// Species: Elusor macrurus
/// NCBI TaxId: 44530
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elusor_macrurus : Elusor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elusor macrurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elusor_macrurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 44530;
}
