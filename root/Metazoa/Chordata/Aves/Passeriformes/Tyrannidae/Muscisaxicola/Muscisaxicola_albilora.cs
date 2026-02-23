namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Muscisaxicola;

/// <summary>
/// Species: Muscisaxicola albilora
/// NCBI TaxId: 123656
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Muscisaxicola_albilora : Muscisaxicola
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Muscisaxicola albilora";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Muscisaxicola_albilora";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 123656;
}
