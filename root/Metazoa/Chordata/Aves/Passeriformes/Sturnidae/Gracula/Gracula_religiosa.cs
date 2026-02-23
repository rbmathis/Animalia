namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Gracula;

/// <summary>
/// Species: Gracula religiosa
/// NCBI TaxId: 116992
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gracula_religiosa : Gracula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gracula religiosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gracula_religiosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 116992;
}
