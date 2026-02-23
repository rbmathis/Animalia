using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Mazarunia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Mazarunia.unclassified_Mazarunia;

/// <summary>
/// Abstract class for unclassified Mazarunia (no rank).
/// NCBI TaxId: 2626027
/// </summary>
public abstract class unclassified_Mazarunia : Mazarunia, Iunclassified_Mazarunia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mazarunia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626027;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mazarunia";
}
