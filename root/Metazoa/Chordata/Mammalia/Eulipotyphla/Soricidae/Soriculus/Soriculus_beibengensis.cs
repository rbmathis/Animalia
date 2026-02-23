namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Soriculus;

/// <summary>
/// Species: Soriculus beibengensis
/// NCBI TaxId: 3116655
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Soriculus_beibengensis : Soriculus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Soriculus beibengensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Soriculus_beibengensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3116655;
}
