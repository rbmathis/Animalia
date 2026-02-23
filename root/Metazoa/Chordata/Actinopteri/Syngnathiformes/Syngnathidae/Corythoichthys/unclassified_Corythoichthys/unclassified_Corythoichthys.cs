using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Corythoichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Corythoichthys.unclassified_Corythoichthys;

/// <summary>
/// Abstract class for unclassified Corythoichthys (no rank).
/// NCBI TaxId: 2631025
/// </summary>
public abstract class unclassified_Corythoichthys : Corythoichthys, Iunclassified_Corythoichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Corythoichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631025;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Corythoichthys";
}
