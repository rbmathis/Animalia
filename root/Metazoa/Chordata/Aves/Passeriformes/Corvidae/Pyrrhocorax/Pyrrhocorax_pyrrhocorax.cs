namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Pyrrhocorax;

/// <summary>
/// Species: Pyrrhocorax pyrrhocorax
/// NCBI TaxId: 56790
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pyrrhocorax_pyrrhocorax : Pyrrhocorax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pyrrhocorax pyrrhocorax";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pyrrhocorax_pyrrhocorax";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56790;
}
