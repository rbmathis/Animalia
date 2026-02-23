namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Oncorhynchus;

/// <summary>
/// Species: Oncorhynchus chrysogaster
/// NCBI TaxId: 648071
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oncorhynchus_chrysogaster : Oncorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oncorhynchus chrysogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oncorhynchus_chrysogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 648071;
}
