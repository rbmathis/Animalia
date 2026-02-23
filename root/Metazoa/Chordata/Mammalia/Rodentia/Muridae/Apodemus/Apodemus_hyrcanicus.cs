namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apodemus;

/// <summary>
/// Species: Apodemus hyrcanicus
/// NCBI TaxId: 1749061
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apodemus_hyrcanicus : Apodemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apodemus hyrcanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apodemus_hyrcanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1749061;
}
