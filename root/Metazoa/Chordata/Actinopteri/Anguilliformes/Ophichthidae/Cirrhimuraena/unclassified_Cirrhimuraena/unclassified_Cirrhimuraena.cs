using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Cirrhimuraena;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Cirrhimuraena.unclassified_Cirrhimuraena;

/// <summary>
/// Abstract class for unclassified Cirrhimuraena (no rank).
/// NCBI TaxId: 2800628
/// </summary>
public abstract class unclassified_Cirrhimuraena : Cirrhimuraena, Iunclassified_Cirrhimuraena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cirrhimuraena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2800628;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cirrhimuraena";
}
