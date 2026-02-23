using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Pseudogastromyzon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Pseudogastromyzon.unclassified_Pseudogastromyzon;

/// <summary>
/// Abstract class for unclassified Pseudogastromyzon (no rank).
/// NCBI TaxId: 2617545
/// </summary>
public abstract class unclassified_Pseudogastromyzon : Pseudogastromyzon, Iunclassified_Pseudogastromyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudogastromyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617545;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudogastromyzon";
}
