namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Kinixys;

/// <summary>
/// Species: Kinixys spekii
/// NCBI TaxId: 286024
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kinixys_spekii : Kinixys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kinixys spekii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kinixys_spekii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 286024;
}
