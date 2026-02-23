namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Acris;

/// <summary>
/// Species: Acris gryllus
/// NCBI TaxId: 317301
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acris_gryllus : Acris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acris gryllus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acris_gryllus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 317301;
}
