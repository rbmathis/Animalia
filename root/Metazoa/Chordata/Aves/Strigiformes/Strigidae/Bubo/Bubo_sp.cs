namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Bubo;

/// <summary>
/// Species: Bubo sp.
/// NCBI TaxId: 1661777
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bubo_sp : Bubo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bubo sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bubo_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1661777;
}
