using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata.Pyrosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata.Pyrosomatidae.unclassified_Pyrosomatidae;

/// <summary>
/// Abstract class for unclassified Pyrosomatidae (no rank).
/// NCBI TaxId: 2877671
/// </summary>
public abstract class unclassified_Pyrosomatidae : Pyrosomatidae, Iunclassified_Pyrosomatidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pyrosomatidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2877671;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pyrosomatidae";
}
