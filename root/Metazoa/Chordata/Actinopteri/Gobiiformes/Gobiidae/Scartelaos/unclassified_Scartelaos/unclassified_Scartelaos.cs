using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Scartelaos;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Scartelaos.unclassified_Scartelaos;

/// <summary>
/// Abstract class for unclassified Scartelaos (no rank).
/// NCBI TaxId: 2839874
/// </summary>
public abstract class unclassified_Scartelaos : Scartelaos, Iunclassified_Scartelaos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scartelaos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2839874;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scartelaos";
}
