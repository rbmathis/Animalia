namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Opistognathidae.Opistognathus;

/// <summary>
/// Species: Opistognathus punctatus
/// NCBI TaxId: 586836
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Opistognathus_punctatus : Opistognathus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Opistognathus punctatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Opistognathus_punctatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 586836;
}
