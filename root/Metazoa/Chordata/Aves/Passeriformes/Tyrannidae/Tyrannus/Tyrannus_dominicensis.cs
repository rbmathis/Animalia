namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Tyrannus;

/// <summary>
/// Species: Tyrannus dominicensis
/// NCBI TaxId: 200370
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tyrannus_dominicensis : Tyrannus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tyrannus dominicensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tyrannus_dominicensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 200370;
}
