namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Himantolophidae.Himantolophus;

/// <summary>
/// Species: Himantolophus sp.
/// NCBI TaxId: 3140544
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Himantolophus_sp : Himantolophus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Himantolophus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Himantolophus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3140544;
}
