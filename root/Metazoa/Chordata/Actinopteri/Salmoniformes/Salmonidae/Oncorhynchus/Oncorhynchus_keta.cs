namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Oncorhynchus;

/// <summary>
/// Species: Oncorhynchus keta
/// NCBI TaxId: 8018
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oncorhynchus_keta : Oncorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oncorhynchus keta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oncorhynchus_keta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8018;
}
