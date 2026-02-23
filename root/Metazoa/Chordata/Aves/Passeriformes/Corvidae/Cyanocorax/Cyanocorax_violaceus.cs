namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cyanocorax;

/// <summary>
/// Species: Cyanocorax violaceus
/// NCBI TaxId: 703287
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyanocorax_violaceus : Cyanocorax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyanocorax violaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyanocorax_violaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 703287;
}
