namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Taeromys;

/// <summary>
/// Species: Taeromys taerae
/// NCBI TaxId: 2683851
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Taeromys_taerae : Taeromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Taeromys taerae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Taeromys_taerae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2683851;
}
