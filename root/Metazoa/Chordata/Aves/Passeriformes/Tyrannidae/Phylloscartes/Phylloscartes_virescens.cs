namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Phylloscartes;

/// <summary>
/// Species: Phylloscartes virescens
/// NCBI TaxId: 1118820
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phylloscartes_virescens : Phylloscartes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phylloscartes virescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phylloscartes_virescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1118820;
}
