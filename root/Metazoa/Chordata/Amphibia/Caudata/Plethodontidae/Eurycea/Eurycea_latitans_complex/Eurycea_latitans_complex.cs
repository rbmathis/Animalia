using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Eurycea;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Eurycea.Eurycea_latitans_complex;

/// <summary>
/// Abstract class for Eurycea latitans complex (no rank).
/// NCBI TaxId: 147892
/// </summary>
public abstract class Eurycea_latitans_complex : Eurycea, IEurycea_latitans_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eurycea latitans complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 147892;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Eurycea_latitans_complex";
}
