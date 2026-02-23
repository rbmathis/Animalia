namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Triakis;

/// <summary>
/// Species: Triakis sp.
/// NCBI TaxId: 94228
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Triakis_sp : Triakis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Triakis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Triakis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 94228;
}
