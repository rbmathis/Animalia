using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Chauliodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Chauliodus.unclassified_Chauliodus;

/// <summary>
/// Abstract class for unclassified Chauliodus (no rank).
/// NCBI TaxId: 2620037
/// </summary>
public abstract class unclassified_Chauliodus : Chauliodus, Iunclassified_Chauliodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chauliodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620037;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chauliodus";
}
