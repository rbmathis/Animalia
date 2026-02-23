namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Picus;

/// <summary>
/// Species: Picus xanthopygaeus
/// NCBI TaxId: 535310
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Picus_xanthopygaeus : Picus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Picus xanthopygaeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Picus_xanthopygaeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 535310;
}
