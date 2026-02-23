using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Gymnelus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Gymnelus.unclassified_Gymnelus;

/// <summary>
/// Abstract class for unclassified Gymnelus (no rank).
/// NCBI TaxId: 2646951
/// </summary>
public abstract class unclassified_Gymnelus : Gymnelus, Iunclassified_Gymnelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gymnelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646951;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gymnelus";
}
