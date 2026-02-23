using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Neoepinnula;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Neoepinnula.unclassified_Neoepinnula;

/// <summary>
/// Abstract class for unclassified Neoepinnula (no rank).
/// NCBI TaxId: 2821160
/// </summary>
public abstract class unclassified_Neoepinnula : Neoepinnula, Iunclassified_Neoepinnula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neoepinnula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821160;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neoepinnula";
}
