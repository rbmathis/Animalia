using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Altolamprologus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Altolamprologus.unclassified_Altolamprologus;

/// <summary>
/// Abstract class for unclassified Altolamprologus (no rank).
/// NCBI TaxId: 2618644
/// </summary>
public abstract class unclassified_Altolamprologus : Altolamprologus, Iunclassified_Altolamprologus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Altolamprologus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618644;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Altolamprologus";
}
