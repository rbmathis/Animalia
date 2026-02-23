namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Empidonax;

/// <summary>
/// Species: Empidonax flaviventris
/// NCBI TaxId: 183529
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Empidonax_flaviventris : Empidonax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Empidonax flaviventris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Empidonax_flaviventris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 183529;
}
