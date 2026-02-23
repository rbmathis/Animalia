namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamiasciurus;

/// <summary>
/// Species: Tamiasciurus mearnsi
/// NCBI TaxId: 144199
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tamiasciurus_mearnsi : Tamiasciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tamiasciurus mearnsi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tamiasciurus_mearnsi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 144199;
}
