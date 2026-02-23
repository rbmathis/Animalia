namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Phanerodon;

/// <summary>
/// Species: Phanerodon furcatus
/// NCBI TaxId: 100200
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phanerodon_furcatus : Phanerodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phanerodon furcatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phanerodon_furcatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100200;
}
