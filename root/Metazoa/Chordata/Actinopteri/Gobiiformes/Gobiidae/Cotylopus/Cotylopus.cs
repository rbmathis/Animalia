using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cotylopus;

/// <summary>
/// Abstract class for Cotylopus (genus).
/// NCBI TaxId: 325684
/// </summary>
public abstract class Cotylopus : Gobiidae, ICotylopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cotylopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 325684;

    /// <inheritdoc />
    public virtual string GenusName => "Cotylopus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
