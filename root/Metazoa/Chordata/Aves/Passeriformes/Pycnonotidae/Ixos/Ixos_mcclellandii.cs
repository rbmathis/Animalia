namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Ixos;

/// <summary>
/// Species: Ixos mcclellandii
/// NCBI TaxId: 182891
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ixos_mcclellandii : Ixos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ixos mcclellandii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ixos_mcclellandii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 182891;
}
