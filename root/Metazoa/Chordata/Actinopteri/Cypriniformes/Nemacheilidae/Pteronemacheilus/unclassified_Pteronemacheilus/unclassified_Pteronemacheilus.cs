using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Pteronemacheilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Pteronemacheilus.unclassified_Pteronemacheilus;

/// <summary>
/// Abstract class for unclassified Pteronemacheilus (no rank).
/// NCBI TaxId: 3383778
/// </summary>
public abstract class unclassified_Pteronemacheilus : Pteronemacheilus, Iunclassified_Pteronemacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pteronemacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3383778;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pteronemacheilus";
}
