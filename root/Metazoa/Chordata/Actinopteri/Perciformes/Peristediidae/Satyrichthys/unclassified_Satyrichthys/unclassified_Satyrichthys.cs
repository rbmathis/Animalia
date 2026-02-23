using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae.Satyrichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae.Satyrichthys.unclassified_Satyrichthys;

/// <summary>
/// Abstract class for unclassified Satyrichthys (no rank).
/// NCBI TaxId: 2646419
/// </summary>
public abstract class unclassified_Satyrichthys : Satyrichthys, Iunclassified_Satyrichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Satyrichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646419;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Satyrichthys";
}
