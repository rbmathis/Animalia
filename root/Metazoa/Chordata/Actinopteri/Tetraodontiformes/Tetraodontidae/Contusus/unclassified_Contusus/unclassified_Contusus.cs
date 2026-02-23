using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Contusus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Contusus.unclassified_Contusus;

/// <summary>
/// Abstract class for unclassified Contusus (no rank).
/// NCBI TaxId: 2636148
/// </summary>
public abstract class unclassified_Contusus : Contusus, Iunclassified_Contusus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Contusus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636148;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Contusus";
}
