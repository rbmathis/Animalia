using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Iniistius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Iniistius.unclassified_Iniistius;

/// <summary>
/// Abstract class for unclassified Iniistius (no rank).
/// NCBI TaxId: 2609516
/// </summary>
public abstract class unclassified_Iniistius : Iniistius, Iunclassified_Iniistius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Iniistius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609516;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Iniistius";
}
