namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Channidae.Channa;

/// <summary>
/// Species: Channa sp.
/// NCBI TaxId: 94222
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Channa_sp : Channa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Channa sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Channa_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 94222;
}
