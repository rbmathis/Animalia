namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Turdus;

/// <summary>
/// Species: Turdus olivaceofuscus
/// NCBI TaxId: 338145
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Turdus_olivaceofuscus : Turdus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Turdus olivaceofuscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Turdus_olivaceofuscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 338145;
}
