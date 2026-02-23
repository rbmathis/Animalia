using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Diretmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Diretmidae.environmental_samples;

/// <summary>
/// Abstract class for environmental samples (no rank).
/// NCBI TaxId: 1986927
/// </summary>
public abstract class environmental_samples : Diretmidae, Ienvironmental_samples
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "environmental samples";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1986927;

    /// <inheritdoc />
    public virtual string Description => "Taxon: environmental_samples";
}
