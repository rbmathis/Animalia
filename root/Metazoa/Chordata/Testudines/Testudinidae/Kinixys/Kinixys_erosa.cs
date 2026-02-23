namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Kinixys;

/// <summary>
/// Species: Kinixys erosa
/// NCBI TaxId: 254401
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kinixys_erosa : Kinixys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kinixys erosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kinixys_erosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 254401;
}
