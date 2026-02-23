namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Coracornis;

/// <summary>
/// Species: Coracornis sanghirensis
/// NCBI TaxId: 675640
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coracornis_sanghirensis : Coracornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coracornis sanghirensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coracornis_sanghirensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 675640;
}
