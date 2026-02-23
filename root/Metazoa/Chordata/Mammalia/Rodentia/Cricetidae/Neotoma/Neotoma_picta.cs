namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neotoma;

/// <summary>
/// Species: Neotoma picta
/// NCBI TaxId: 316115
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neotoma_picta : Neotoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neotoma picta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neotoma_picta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 316115;
}
