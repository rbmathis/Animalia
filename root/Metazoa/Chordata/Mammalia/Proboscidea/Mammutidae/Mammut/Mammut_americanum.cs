namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Mammutidae.Mammut;

/// <summary>
/// Species: Mammut americanum
/// NCBI TaxId: 39053
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mammut_americanum : Mammut
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mammut americanum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mammut_americanum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 39053;
}
