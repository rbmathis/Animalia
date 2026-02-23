namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Phylloscartes;

/// <summary>
/// Species: Phylloscartes ophthalmicus
/// NCBI TaxId: 649800
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phylloscartes_ophthalmicus : Phylloscartes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phylloscartes ophthalmicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phylloscartes_ophthalmicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 649800;
}
