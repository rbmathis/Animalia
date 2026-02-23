namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Peliperdix;

/// <summary>
/// Species: Peliperdix coqui
/// NCBI TaxId: 9021
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Peliperdix_coqui : Peliperdix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Peliperdix coqui";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Peliperdix_coqui";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9021;
}
