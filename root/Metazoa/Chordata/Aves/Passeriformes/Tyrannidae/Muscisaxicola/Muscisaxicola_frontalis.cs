namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Muscisaxicola;

/// <summary>
/// Species: Muscisaxicola frontalis
/// NCBI TaxId: 123665
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Muscisaxicola_frontalis : Muscisaxicola
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Muscisaxicola frontalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Muscisaxicola_frontalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 123665;
}
