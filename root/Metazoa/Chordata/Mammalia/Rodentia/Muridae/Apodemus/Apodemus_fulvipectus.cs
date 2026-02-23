namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apodemus;

/// <summary>
/// Species: Apodemus fulvipectus
/// NCBI TaxId: 134907
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apodemus_fulvipectus : Apodemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apodemus fulvipectus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apodemus_fulvipectus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 134907;
}
