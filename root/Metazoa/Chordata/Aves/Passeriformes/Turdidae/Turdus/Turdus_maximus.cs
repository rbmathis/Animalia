namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Turdus;

/// <summary>
/// Species: Turdus maximus
/// NCBI TaxId: 486390
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Turdus_maximus : Turdus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Turdus maximus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Turdus_maximus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 486390;
}
