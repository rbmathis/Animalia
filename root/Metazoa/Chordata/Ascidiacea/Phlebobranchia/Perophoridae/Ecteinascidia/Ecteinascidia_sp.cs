namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Perophoridae.Ecteinascidia;

/// <summary>
/// Species: Ecteinascidia sp.
/// NCBI TaxId: 3140046
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ecteinascidia_sp : Ecteinascidia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ecteinascidia sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ecteinascidia_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3140046;
}
