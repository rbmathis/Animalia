namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Pachyptila;

/// <summary>
/// Species: Pachyptila crassirostris
/// NCBI TaxId: 881912
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachyptila_crassirostris : Pachyptila
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachyptila crassirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachyptila_crassirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 881912;
}
