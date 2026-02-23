using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Phalloceros;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Phalloceros.unclassified_Phalloceros;

/// <summary>
/// Abstract class for unclassified Phalloceros (no rank).
/// NCBI TaxId: 2632191
/// </summary>
public abstract class unclassified_Phalloceros : Phalloceros, Iunclassified_Phalloceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phalloceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632191;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phalloceros";
}
