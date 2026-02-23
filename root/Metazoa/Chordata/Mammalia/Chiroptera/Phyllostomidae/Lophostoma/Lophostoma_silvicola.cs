namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Lophostoma;

/// <summary>
/// Species: Lophostoma silvicola
/// NCBI TaxId: 3370180
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lophostoma_silvicola : Lophostoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lophostoma silvicola";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lophostoma_silvicola";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3370180;
}
