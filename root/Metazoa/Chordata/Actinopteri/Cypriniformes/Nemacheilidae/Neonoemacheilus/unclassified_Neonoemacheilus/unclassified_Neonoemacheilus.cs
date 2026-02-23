using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Neonoemacheilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Neonoemacheilus.unclassified_Neonoemacheilus;

/// <summary>
/// Abstract class for unclassified Neonoemacheilus (no rank).
/// NCBI TaxId: 2624322
/// </summary>
public abstract class unclassified_Neonoemacheilus : Neonoemacheilus, Iunclassified_Neonoemacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neonoemacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624322;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neonoemacheilus";
}
