namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apodemus;

/// <summary>
/// Species: Apodemus latronum
/// NCBI TaxId: 214933
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apodemus_latronum : Apodemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apodemus latronum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apodemus_latronum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 214933;
}
