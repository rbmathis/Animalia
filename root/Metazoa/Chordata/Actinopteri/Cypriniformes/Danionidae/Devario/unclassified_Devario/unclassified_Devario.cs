using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Devario;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Devario.unclassified_Devario;

/// <summary>
/// Abstract class for unclassified Devario (no rank).
/// NCBI TaxId: 2634144
/// </summary>
public abstract class unclassified_Devario : Devario, Iunclassified_Devario
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Devario";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634144;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Devario";
}
