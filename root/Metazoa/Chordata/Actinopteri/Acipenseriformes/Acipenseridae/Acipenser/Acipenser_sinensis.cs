namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Acipenser;

/// <summary>
/// Species: Acipenser sinensis
/// NCBI TaxId: 61970
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acipenser_sinensis : Acipenser
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acipenser sinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acipenser_sinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61970;
}
