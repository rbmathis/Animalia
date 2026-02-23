namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Empidonax;

/// <summary>
/// Species: Empidonax minimus
/// NCBI TaxId: 28730
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Empidonax_minimus : Empidonax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Empidonax minimus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Empidonax_minimus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 28730;
}
