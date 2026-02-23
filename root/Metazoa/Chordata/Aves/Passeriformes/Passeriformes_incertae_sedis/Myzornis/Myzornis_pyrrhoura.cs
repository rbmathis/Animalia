namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeriformes_incertae_sedis.Myzornis;

/// <summary>
/// Species: Myzornis pyrrhoura
/// NCBI TaxId: 634318
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myzornis_pyrrhoura : Myzornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myzornis pyrrhoura";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myzornis_pyrrhoura";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 634318;
}
