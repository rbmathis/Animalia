namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

/// <summary>
/// Species: Oecomys tapajinus
/// NCBI TaxId: 2213112
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oecomys_tapajinus : Oecomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oecomys tapajinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oecomys_tapajinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2213112;
}
