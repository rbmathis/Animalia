namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamiasciurus;

/// <summary>
/// Species: Tamiasciurus hudsonicus x Tamiasciurus douglasii
/// NCBI TaxId: 2794997
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tamiasciurus_hudsonicus_x_Tamiasciurus_douglasii : Tamiasciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tamiasciurus hudsonicus x Tamiasciurus douglasii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tamiasciurus_hudsonicus_x_Tamiasciurus_douglasii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2794997;
}
