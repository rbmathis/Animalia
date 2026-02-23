using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Callorhinchidae.Callorhinchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Callorhinchidae.Callorhinchus.environmental_samples;

/// <summary>
/// Abstract class for environmental samples (no rank).
/// NCBI TaxId: 941942
/// </summary>
public abstract class environmental_samples : Callorhinchus, Ienvironmental_samples
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "environmental samples";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 941942;

    /// <inheritdoc />
    public virtual string Description => "Taxon: environmental_samples";
}
