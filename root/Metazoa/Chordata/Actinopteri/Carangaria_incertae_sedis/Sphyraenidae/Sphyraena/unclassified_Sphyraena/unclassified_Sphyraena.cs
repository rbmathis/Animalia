using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Sphyraenidae.Sphyraena;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Sphyraenidae.Sphyraena.unclassified_Sphyraena;

/// <summary>
/// Abstract class for unclassified Sphyraena (no rank).
/// NCBI TaxId: 2641214
/// </summary>
public abstract class unclassified_Sphyraena : Sphyraena, Iunclassified_Sphyraena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sphyraena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641214;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sphyraena";
}
