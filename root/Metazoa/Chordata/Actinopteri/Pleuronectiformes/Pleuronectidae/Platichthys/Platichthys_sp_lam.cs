namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Platichthys;

/// <summary>
/// Species: Platichthys sp. lam
/// NCBI TaxId: 2516292
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platichthys_sp_lam : Platichthys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platichthys sp. lam";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platichthys_sp_lam";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2516292;
}
