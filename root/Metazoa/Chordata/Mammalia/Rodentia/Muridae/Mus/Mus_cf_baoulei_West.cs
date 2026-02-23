namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus cf. baoulei West
/// NCBI TaxId: 1582502
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_cf_baoulei_West : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus cf. baoulei West";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_cf_baoulei_West";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1582502;
}
