namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apodemus;

/// <summary>
/// Species: Apodemus flavicollis
/// NCBI TaxId: 54292
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apodemus_flavicollis : Apodemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apodemus flavicollis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apodemus_flavicollis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 54292;
}
