using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudolithoxus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudolithoxus.unclassified_Pseudolithoxus;

/// <summary>
/// Abstract class for unclassified Pseudolithoxus (no rank).
/// NCBI TaxId: 2623323
/// </summary>
public abstract class unclassified_Pseudolithoxus : Pseudolithoxus, Iunclassified_Pseudolithoxus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudolithoxus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623323;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudolithoxus";
}
