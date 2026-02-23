namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Odontobatrachidae.Odontobatrachus;

/// <summary>
/// Species: Odontobatrachus natator
/// NCBI TaxId: 322504
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Odontobatrachus_natator : Odontobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Odontobatrachus natator";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Odontobatrachus_natator";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 322504;
}
