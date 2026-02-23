using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Terapon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Terapon.unclassified_Terapon;

/// <summary>
/// Abstract class for unclassified Terapon (no rank).
/// NCBI TaxId: 2990336
/// </summary>
public abstract class unclassified_Terapon : Terapon, Iunclassified_Terapon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Terapon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2990336;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Terapon";
}
