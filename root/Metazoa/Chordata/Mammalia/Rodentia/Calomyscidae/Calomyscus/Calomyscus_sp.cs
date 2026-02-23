namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Calomyscidae.Calomyscus;

/// <summary>
/// Species: Calomyscus sp.
/// NCBI TaxId: 10133
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calomyscus_sp : Calomyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calomyscus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calomyscus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10133;
}
