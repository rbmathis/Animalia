namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Johnius;

/// <summary>
/// Species: Johnius plagiostoma
/// NCBI TaxId: 1789957
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Johnius_plagiostoma : Johnius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Johnius plagiostoma";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Johnius_plagiostoma";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1789957;
}
