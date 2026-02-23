namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Porphyrio;

/// <summary>
/// Species: Porphyrio melanotus
/// NCBI TaxId: 72013
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Porphyrio_melanotus : Porphyrio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Porphyrio melanotus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Porphyrio_melanotus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 72013;
}
