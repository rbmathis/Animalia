using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.Saurida;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.Saurida.unclassified_Saurida;

/// <summary>
/// Abstract class for unclassified Saurida (no rank).
/// NCBI TaxId: 2646476
/// </summary>
public abstract class unclassified_Saurida : Saurida, Iunclassified_Saurida
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Saurida";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646476;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Saurida";
}
