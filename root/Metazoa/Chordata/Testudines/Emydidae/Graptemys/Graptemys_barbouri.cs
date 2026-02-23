namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Graptemys;

/// <summary>
/// Species: Graptemys barbouri
/// NCBI TaxId: 33563
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Graptemys_barbouri : Graptemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Graptemys barbouri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Graptemys_barbouri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 33563;
}
