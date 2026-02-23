using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cichlasoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cichlasoma.unclassified_Cichlasoma;

/// <summary>
/// Abstract class for unclassified Cichlasoma (no rank).
/// NCBI TaxId: 2630807
/// </summary>
public abstract class unclassified_Cichlasoma : Cichlasoma, Iunclassified_Cichlasoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cichlasoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630807;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cichlasoma";
}
