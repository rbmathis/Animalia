namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Mastacembelidae.Mastacembelus;

/// <summary>
/// Species: Mastacembelus armatus
/// NCBI TaxId: 205130
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mastacembelus_armatus : Mastacembelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mastacembelus armatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mastacembelus_armatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 205130;
}
