namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Poecilia;

/// <summary>
/// Species: Poecilia sp. 'Patuca'
/// NCBI TaxId: 1605795
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Poecilia_sp_Patuca : Poecilia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Poecilia sp. 'Patuca'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Poecilia_sp_Patuca";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1605795;
}
