namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Misgurnus;

/// <summary>
/// Species: Misgurnus anguillicaudatus
/// NCBI TaxId: 75329
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Misgurnus_anguillicaudatus : Misgurnus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Misgurnus anguillicaudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Misgurnus_anguillicaudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75329;
}
