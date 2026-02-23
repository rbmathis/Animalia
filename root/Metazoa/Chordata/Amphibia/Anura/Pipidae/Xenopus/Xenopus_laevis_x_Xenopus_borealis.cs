namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

/// <summary>
/// Species: Xenopus laevis x Xenopus borealis
/// NCBI TaxId: 558434
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenopus_laevis_x_Xenopus_borealis : Xenopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenopus laevis x Xenopus borealis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenopus_laevis_x_Xenopus_borealis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 558434;
}
