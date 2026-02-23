namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Aspiorhynchus;

/// <summary>
/// Species: Aspiorhynchus laticeps
/// NCBI TaxId: 748366
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aspiorhynchus_laticeps : Aspiorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aspiorhynchus laticeps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aspiorhynchus_laticeps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 748366;
}
