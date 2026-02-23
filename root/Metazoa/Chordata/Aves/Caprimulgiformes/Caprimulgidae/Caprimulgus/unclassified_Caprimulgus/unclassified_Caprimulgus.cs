using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Caprimulgus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Caprimulgus.unclassified_Caprimulgus;

/// <summary>
/// Abstract class for unclassified Caprimulgus (no rank).
/// NCBI TaxId: 2644279
/// </summary>
public abstract class unclassified_Caprimulgus : Caprimulgus, Iunclassified_Caprimulgus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Caprimulgus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644279;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Caprimulgus";
}
