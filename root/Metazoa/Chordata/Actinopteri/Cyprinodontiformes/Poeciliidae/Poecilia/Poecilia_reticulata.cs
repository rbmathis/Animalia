namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Poecilia;

/// <summary>
/// Species: Poecilia reticulata
/// NCBI TaxId: 8081
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Poecilia_reticulata : Poecilia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Poecilia reticulata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Poecilia_reticulata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8081;
}
