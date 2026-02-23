using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Mesonoemacheilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Mesonoemacheilus.unclassified_Mesonoemacheilus;

/// <summary>
/// Abstract class for unclassified Mesonoemacheilus (no rank).
/// NCBI TaxId: 2717467
/// </summary>
public abstract class unclassified_Mesonoemacheilus : Mesonoemacheilus, Iunclassified_Mesonoemacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mesonoemacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2717467;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mesonoemacheilus";
}
