namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turnagra;

/// <summary>
/// Species: Turnagra capensis
/// NCBI TaxId: 46906
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Turnagra_capensis : Turnagra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Turnagra capensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Turnagra_capensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 46906;
}
