namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Graptemys;

/// <summary>
/// Species: Graptemys sp.
/// NCBI TaxId: 2060766
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Graptemys_sp : Graptemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Graptemys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Graptemys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2060766;
}
