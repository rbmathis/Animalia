namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Camarhynchus;

/// <summary>
/// Species: Camarhynchus parvulus
/// NCBI TaxId: 87175
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Camarhynchus_parvulus : Camarhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Camarhynchus parvulus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Camarhynchus_parvulus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 87175;
}
