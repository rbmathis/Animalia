namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Camarhynchus;

/// <summary>
/// Species: Camarhynchus psittacula
/// NCBI TaxId: 87178
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Camarhynchus_psittacula : Camarhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Camarhynchus psittacula";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Camarhynchus_psittacula";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 87178;
}
