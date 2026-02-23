namespace AnimalKingdom.root.Metazoa.Chordata.Craniata;

/// <summary>
/// Species: Craniata sp.
/// NCBI TaxId: 2813636
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Craniata_sp : Craniata
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Craniata sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Craniata_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2813636;
}
