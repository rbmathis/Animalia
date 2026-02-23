using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Nemacheilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Nemacheilus.unclassified_Nemacheilus;

/// <summary>
/// Abstract class for unclassified Nemacheilus (no rank).
/// NCBI TaxId: 2626281
/// </summary>
public abstract class unclassified_Nemacheilus : Nemacheilus, Iunclassified_Nemacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nemacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626281;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nemacheilus";
}
