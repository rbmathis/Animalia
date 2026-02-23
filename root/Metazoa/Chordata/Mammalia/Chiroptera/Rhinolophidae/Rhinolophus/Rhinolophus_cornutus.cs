namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinolophidae.Rhinolophus;

/// <summary>
/// Species: Rhinolophus cornutus
/// NCBI TaxId: 196296
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinolophus_cornutus : Rhinolophus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinolophus cornutus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinolophus_cornutus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 196296;
}
