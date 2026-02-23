using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Candidia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Candidia.unclassified_Candidia;

/// <summary>
/// Abstract class for unclassified Candidia (no rank).
/// NCBI TaxId: 2645106
/// </summary>
public abstract class unclassified_Candidia : Candidia, Iunclassified_Candidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Candidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645106;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Candidia";
}
