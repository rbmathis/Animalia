using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae.Atrophacanthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae.Atrophacanthus.unclassified_Atrophacanthus;

/// <summary>
/// Abstract class for unclassified Atrophacanthus (no rank).
/// NCBI TaxId: 2898572
/// </summary>
public abstract class unclassified_Atrophacanthus : Atrophacanthus, Iunclassified_Atrophacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atrophacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2898572;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atrophacanthus";
}
