namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Graptemys;

/// <summary>
/// Species: Graptemys sabinensis
/// NCBI TaxId: 580252
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Graptemys_sabinensis : Graptemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Graptemys sabinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Graptemys_sabinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 580252;
}
