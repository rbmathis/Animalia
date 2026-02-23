namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Oncorhynchus;

/// <summary>
/// Species: Oncorhynchus mykiss
/// NCBI TaxId: 8022
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oncorhynchus_mykiss : Oncorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oncorhynchus mykiss";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oncorhynchus_mykiss";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8022;
}
