namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Turdus;

/// <summary>
/// Species: Turdus anthracinus
/// NCBI TaxId: 2653039
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Turdus_anthracinus : Turdus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Turdus anthracinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Turdus_anthracinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2653039;
}
