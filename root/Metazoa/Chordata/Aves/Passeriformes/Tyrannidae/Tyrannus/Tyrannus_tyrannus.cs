namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Tyrannus;

/// <summary>
/// Species: Tyrannus tyrannus
/// NCBI TaxId: 43165
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tyrannus_tyrannus : Tyrannus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tyrannus tyrannus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tyrannus_tyrannus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 43165;
}
