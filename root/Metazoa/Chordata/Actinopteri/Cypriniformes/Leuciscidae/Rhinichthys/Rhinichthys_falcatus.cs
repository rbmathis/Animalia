namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Rhinichthys;

/// <summary>
/// Species: Rhinichthys falcatus
/// NCBI TaxId: 407094
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinichthys_falcatus : Rhinichthys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinichthys falcatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinichthys_falcatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 407094;
}
