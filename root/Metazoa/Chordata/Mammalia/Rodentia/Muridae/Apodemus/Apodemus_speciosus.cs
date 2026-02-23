namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apodemus;

/// <summary>
/// Species: Apodemus speciosus
/// NCBI TaxId: 105296
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apodemus_speciosus : Apodemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apodemus speciosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apodemus_speciosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 105296;
}
