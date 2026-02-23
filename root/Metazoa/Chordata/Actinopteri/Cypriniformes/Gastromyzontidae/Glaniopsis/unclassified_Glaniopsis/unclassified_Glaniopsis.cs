using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Glaniopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Glaniopsis.unclassified_Glaniopsis;

/// <summary>
/// Abstract class for unclassified Glaniopsis (no rank).
/// NCBI TaxId: 2633555
/// </summary>
public abstract class unclassified_Glaniopsis : Glaniopsis, Iunclassified_Glaniopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glaniopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633555;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glaniopsis";
}
