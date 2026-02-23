namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cyanocorax;

/// <summary>
/// Species: Cyanocorax caeruleus
/// NCBI TaxId: 703281
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyanocorax_caeruleus : Cyanocorax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyanocorax caeruleus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyanocorax_caeruleus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 703281;
}
