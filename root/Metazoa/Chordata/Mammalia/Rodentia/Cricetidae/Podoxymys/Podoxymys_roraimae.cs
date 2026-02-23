namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Podoxymys;

/// <summary>
/// Species: Podoxymys roraimae
/// NCBI TaxId: 1604870
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Podoxymys_roraimae : Podoxymys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Podoxymys roraimae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Podoxymys_roraimae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1604870;
}
