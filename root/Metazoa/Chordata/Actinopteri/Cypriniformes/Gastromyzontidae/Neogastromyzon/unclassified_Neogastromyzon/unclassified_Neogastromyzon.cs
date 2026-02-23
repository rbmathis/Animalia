using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Neogastromyzon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Neogastromyzon.unclassified_Neogastromyzon;

/// <summary>
/// Abstract class for unclassified Neogastromyzon (no rank).
/// NCBI TaxId: 2626405
/// </summary>
public abstract class unclassified_Neogastromyzon : Neogastromyzon, Iunclassified_Neogastromyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neogastromyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626405;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neogastromyzon";
}
