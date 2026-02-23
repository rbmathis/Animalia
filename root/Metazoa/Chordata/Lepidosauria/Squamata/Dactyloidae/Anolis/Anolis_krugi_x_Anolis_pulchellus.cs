namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis krugi x Anolis pulchellus
/// NCBI TaxId: 3079997
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_krugi_x_Anolis_pulchellus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis krugi x Anolis pulchellus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_krugi_x_Anolis_pulchellus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3079997;
}
