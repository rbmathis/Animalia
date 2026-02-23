using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Pomadasys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Pomadasys.unclassified_Pomadasys;

/// <summary>
/// Abstract class for unclassified Pomadasys (no rank).
/// NCBI TaxId: 2685060
/// </summary>
public abstract class unclassified_Pomadasys : Pomadasys, Iunclassified_Pomadasys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pomadasys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685060;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pomadasys";
}
