namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Graptemys;

/// <summary>
/// Species: Graptemys flavimaculata
/// NCBI TaxId: 33566
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Graptemys_flavimaculata : Graptemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Graptemys flavimaculata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Graptemys_flavimaculata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 33566;
}
