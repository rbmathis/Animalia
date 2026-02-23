using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Turcinoemacheilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Turcinoemacheilus.unclassified_Turcinoemacheilus;

/// <summary>
/// Abstract class for unclassified Turcinoemacheilus (no rank).
/// NCBI TaxId: 2632354
/// </summary>
public abstract class unclassified_Turcinoemacheilus : Turcinoemacheilus, Iunclassified_Turcinoemacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Turcinoemacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632354;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Turcinoemacheilus";
}
