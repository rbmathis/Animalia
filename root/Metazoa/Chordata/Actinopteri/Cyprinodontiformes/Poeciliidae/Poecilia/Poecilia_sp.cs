namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Poecilia;

/// <summary>
/// Species: Poecilia sp.
/// NCBI TaxId: 3049104
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Poecilia_sp : Poecilia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Poecilia sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Poecilia_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3049104;
}
