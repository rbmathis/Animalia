namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Paradoxornis;

/// <summary>
/// Species: Paradoxornis fulvifrons
/// NCBI TaxId: 3150596
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paradoxornis_fulvifrons : Paradoxornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paradoxornis fulvifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paradoxornis_fulvifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150596;
}
