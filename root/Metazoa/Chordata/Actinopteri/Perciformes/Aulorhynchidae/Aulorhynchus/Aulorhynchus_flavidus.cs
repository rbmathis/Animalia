namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Aulorhynchidae.Aulorhynchus;

/// <summary>
/// Species: Aulorhynchus flavidus
/// NCBI TaxId: 240152
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aulorhynchus_flavidus : Aulorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aulorhynchus flavidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aulorhynchus_flavidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 240152;
}
