namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Malacorhynchus;

/// <summary>
/// Species: Malacorhynchus membranaceus
/// NCBI TaxId: 45646
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Malacorhynchus_membranaceus : Malacorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Malacorhynchus membranaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Malacorhynchus_membranaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 45646;
}
