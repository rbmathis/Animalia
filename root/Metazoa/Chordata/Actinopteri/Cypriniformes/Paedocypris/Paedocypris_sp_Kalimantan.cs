namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Paedocypris;

/// <summary>
/// Species: Paedocypris sp. Kalimantan
/// NCBI TaxId: 432427
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paedocypris_sp_Kalimantan : Paedocypris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paedocypris sp. Kalimantan";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paedocypris_sp_Kalimantan";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 432427;
}
