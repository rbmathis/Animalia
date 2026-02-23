namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neacomys;

/// <summary>
/// Species: Neacomys sp.
/// NCBI TaxId: 37027
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neacomys_sp : Neacomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neacomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neacomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37027;
}
