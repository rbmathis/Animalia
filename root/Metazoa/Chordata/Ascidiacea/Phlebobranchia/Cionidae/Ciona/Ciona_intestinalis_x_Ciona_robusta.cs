namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Cionidae.Ciona;

/// <summary>
/// Species: Ciona intestinalis x Ciona robusta
/// NCBI TaxId: 2893330
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ciona_intestinalis_x_Ciona_robusta : Ciona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ciona intestinalis x Ciona robusta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ciona_intestinalis_x_Ciona_robusta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2893330;
}
