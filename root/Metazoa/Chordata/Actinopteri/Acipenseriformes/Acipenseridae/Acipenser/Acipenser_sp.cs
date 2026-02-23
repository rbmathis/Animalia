namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Acipenser;

/// <summary>
/// Species: Acipenser sp.
/// NCBI TaxId: 30673
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acipenser_sp : Acipenser
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acipenser sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acipenser_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30673;
}
