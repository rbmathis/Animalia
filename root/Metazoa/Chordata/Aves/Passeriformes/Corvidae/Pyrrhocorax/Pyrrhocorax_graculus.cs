namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Pyrrhocorax;

/// <summary>
/// Species: Pyrrhocorax graculus
/// NCBI TaxId: 56789
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pyrrhocorax_graculus : Pyrrhocorax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pyrrhocorax graculus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pyrrhocorax_graculus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56789;
}
