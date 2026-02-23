namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Misgurnus;

/// <summary>
/// Species: Misgurnus amamianus
/// NCBI TaxId: 2012985
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Misgurnus_amamianus : Misgurnus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Misgurnus amamianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Misgurnus_amamianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2012985;
}
