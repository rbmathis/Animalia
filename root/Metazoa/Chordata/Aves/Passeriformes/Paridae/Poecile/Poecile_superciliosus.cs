namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Poecile;

/// <summary>
/// Species: Poecile superciliosus
/// NCBI TaxId: 156559
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Poecile_superciliosus : Poecile
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Poecile superciliosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Poecile_superciliosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 156559;
}
