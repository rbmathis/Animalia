using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Acanthocybium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Acanthocybium.unclassified_Acanthocybium;

/// <summary>
/// Abstract class for unclassified Acanthocybium (no rank).
/// NCBI TaxId: 2646947
/// </summary>
public abstract class unclassified_Acanthocybium : Acanthocybium, Iunclassified_Acanthocybium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acanthocybium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646947;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acanthocybium";
}
