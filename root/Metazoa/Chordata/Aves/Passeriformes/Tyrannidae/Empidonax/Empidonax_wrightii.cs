namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Empidonax;

/// <summary>
/// Species: Empidonax wrightii
/// NCBI TaxId: 209629
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Empidonax_wrightii : Empidonax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Empidonax wrightii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Empidonax_wrightii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 209629;
}
