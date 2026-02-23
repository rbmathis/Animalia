namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Oncorhynchus;

/// <summary>
/// Species: Oncorhynchus kisutch
/// NCBI TaxId: 8019
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oncorhynchus_kisutch : Oncorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oncorhynchus kisutch";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oncorhynchus_kisutch";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8019;
}
