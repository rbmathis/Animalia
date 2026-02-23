namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus cf. callewaerti
/// NCBI TaxId: 1890198
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_cf_callewaerti : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus cf. callewaerti";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_cf_callewaerti";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1890198;
}
