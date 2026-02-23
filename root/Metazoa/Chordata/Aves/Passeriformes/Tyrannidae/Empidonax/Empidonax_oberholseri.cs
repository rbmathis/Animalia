namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Empidonax;

/// <summary>
/// Species: Empidonax oberholseri
/// NCBI TaxId: 142470
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Empidonax_oberholseri : Empidonax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Empidonax oberholseri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Empidonax_oberholseri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 142470;
}
