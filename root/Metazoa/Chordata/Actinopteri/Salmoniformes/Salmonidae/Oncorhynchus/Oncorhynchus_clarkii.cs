namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Oncorhynchus;

/// <summary>
/// Species: Oncorhynchus clarkii
/// NCBI TaxId: 30962
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oncorhynchus_clarkii : Oncorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oncorhynchus clarkii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oncorhynchus_clarkii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30962;
}
