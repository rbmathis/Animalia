using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Psednos;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Psednos.unclassified_Psednos;

/// <summary>
/// Abstract class for unclassified Psednos (no rank).
/// NCBI TaxId: 3071818
/// </summary>
public abstract class unclassified_Psednos : Psednos, Iunclassified_Psednos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psednos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3071818;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psednos";
}
