namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Bathydraco;

/// <summary>
/// Species: Bathydraco antarcticus
/// NCBI TaxId: 487670
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bathydraco_antarcticus : Bathydraco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bathydraco antarcticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bathydraco_antarcticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 487670;
}
