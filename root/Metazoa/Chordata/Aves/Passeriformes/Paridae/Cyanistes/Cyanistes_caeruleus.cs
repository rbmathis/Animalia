namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Cyanistes;

/// <summary>
/// Species: Cyanistes caeruleus
/// NCBI TaxId: 156563
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyanistes_caeruleus : Cyanistes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyanistes caeruleus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyanistes_caeruleus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 156563;
}
