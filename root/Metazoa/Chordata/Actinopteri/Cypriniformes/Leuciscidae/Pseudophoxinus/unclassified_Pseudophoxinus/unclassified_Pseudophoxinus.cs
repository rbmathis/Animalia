using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pseudophoxinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pseudophoxinus.unclassified_Pseudophoxinus;

/// <summary>
/// Abstract class for unclassified Pseudophoxinus (no rank).
/// NCBI TaxId: 2597774
/// </summary>
public abstract class unclassified_Pseudophoxinus : Pseudophoxinus, Iunclassified_Pseudophoxinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudophoxinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2597774;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudophoxinus";
}
