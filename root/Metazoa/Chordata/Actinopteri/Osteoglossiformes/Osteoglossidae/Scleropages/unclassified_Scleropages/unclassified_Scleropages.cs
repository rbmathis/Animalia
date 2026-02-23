using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae.Scleropages;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae.Scleropages.unclassified_Scleropages;

/// <summary>
/// Abstract class for unclassified Scleropages (no rank).
/// NCBI TaxId: 2645763
/// </summary>
public abstract class unclassified_Scleropages : Scleropages, Iunclassified_Scleropages
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scleropages";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645763;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scleropages";
}
