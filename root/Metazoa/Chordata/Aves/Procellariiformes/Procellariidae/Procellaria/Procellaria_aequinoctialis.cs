namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Procellaria;

/// <summary>
/// Species: Procellaria aequinoctialis
/// NCBI TaxId: 53665
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Procellaria_aequinoctialis : Procellaria
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Procellaria aequinoctialis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Procellaria_aequinoctialis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 53665;
}
