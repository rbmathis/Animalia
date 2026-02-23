namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Neotamias;

/// <summary>
/// Species: Neotamias siskiyou
/// NCBI TaxId: 3370383
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neotamias_siskiyou : Neotamias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neotamias siskiyou";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neotamias_siskiyou";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3370383;
}
