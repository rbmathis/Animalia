namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Empidonax;

/// <summary>
/// Species: Empidonax virescens
/// NCBI TaxId: 209628
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Empidonax_virescens : Empidonax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Empidonax virescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Empidonax_virescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 209628;
}
