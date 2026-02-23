namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Empidonax;

/// <summary>
/// Species: Empidonax fulvifrons
/// NCBI TaxId: 209623
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Empidonax_fulvifrons : Empidonax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Empidonax fulvifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Empidonax_fulvifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 209623;
}
