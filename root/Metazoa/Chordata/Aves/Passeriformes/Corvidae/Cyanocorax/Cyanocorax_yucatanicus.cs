namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cyanocorax;

/// <summary>
/// Species: Cyanocorax yucatanicus
/// NCBI TaxId: 402026
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyanocorax_yucatanicus : Cyanocorax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyanocorax yucatanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyanocorax_yucatanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 402026;
}
