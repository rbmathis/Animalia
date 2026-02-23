namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Turdus;

/// <summary>
/// Species: Turdus fumigatus
/// NCBI TaxId: 200368
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Turdus_fumigatus : Turdus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Turdus fumigatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Turdus_fumigatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 200368;
}
