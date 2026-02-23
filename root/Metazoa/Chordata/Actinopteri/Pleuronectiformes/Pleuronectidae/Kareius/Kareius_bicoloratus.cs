namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Kareius;

/// <summary>
/// Species: Kareius bicoloratus
/// NCBI TaxId: 143345
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kareius_bicoloratus : Kareius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kareius bicoloratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kareius_bicoloratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 143345;
}
