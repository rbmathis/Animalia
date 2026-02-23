using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata.unclassified_Pyrosomata;

/// <summary>
/// Abstract class for unclassified Pyrosomata (no rank).
/// NCBI TaxId: 2072423
/// </summary>
public abstract class unclassified_Pyrosomata : Pyrosomata, Iunclassified_Pyrosomata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pyrosomata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2072423;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pyrosomata";
}
