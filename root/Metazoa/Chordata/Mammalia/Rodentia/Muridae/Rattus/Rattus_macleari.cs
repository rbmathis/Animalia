namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

/// <summary>
/// Species: Rattus macleari
/// NCBI TaxId: 570414
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rattus_macleari : Rattus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rattus macleari";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rattus_macleari";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 570414;
}
