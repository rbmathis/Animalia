using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Centropomidae.Centropomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Centropomidae.Centropomus.unclassified_Centropomus;

/// <summary>
/// Abstract class for unclassified Centropomus (no rank).
/// NCBI TaxId: 2630619
/// </summary>
public abstract class unclassified_Centropomus : Centropomus, Iunclassified_Centropomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Centropomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630619;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Centropomus";
}
