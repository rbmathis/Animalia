namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus cf. gratus
/// NCBI TaxId: 3086089
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_cf_gratus : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus cf. gratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_cf_gratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3086089;
}
