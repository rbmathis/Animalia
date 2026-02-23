namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Pleurodeles;

/// <summary>
/// Species: Pleurodeles nebulosus
/// NCBI TaxId: 339878
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pleurodeles_nebulosus : Pleurodeles
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pleurodeles nebulosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pleurodeles_nebulosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 339878;
}
