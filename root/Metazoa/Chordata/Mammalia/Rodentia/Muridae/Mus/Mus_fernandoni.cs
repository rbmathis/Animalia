namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus fernandoni
/// NCBI TaxId: 2162866
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_fernandoni : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus fernandoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_fernandoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2162866;
}
