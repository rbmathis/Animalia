using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Opsariichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Opsariichthys.unclassified_Opsariichthys;

/// <summary>
/// Abstract class for unclassified Opsariichthys (no rank).
/// NCBI TaxId: 2636530
/// </summary>
public abstract class unclassified_Opsariichthys : Opsariichthys, Iunclassified_Opsariichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Opsariichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636530;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Opsariichthys";
}
