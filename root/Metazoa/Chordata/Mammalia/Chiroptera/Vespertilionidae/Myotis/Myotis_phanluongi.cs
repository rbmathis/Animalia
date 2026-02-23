namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis phanluongi
/// NCBI TaxId: 572313
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_phanluongi : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis phanluongi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_phanluongi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 572313;
}
