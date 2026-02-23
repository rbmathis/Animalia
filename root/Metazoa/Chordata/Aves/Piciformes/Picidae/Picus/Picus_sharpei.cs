namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Picus;

/// <summary>
/// Species: Picus sharpei
/// NCBI TaxId: 2039165
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Picus_sharpei : Picus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Picus sharpei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Picus_sharpei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2039165;
}
