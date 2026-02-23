namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Regulidae.Regulus;

/// <summary>
/// Species: Regulus regulus
/// NCBI TaxId: 68468
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Regulus_regulus : Regulus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Regulus regulus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Regulus_regulus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 68468;
}
