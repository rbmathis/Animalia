using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Astrabe;

/// <summary>
/// Abstract class for Astrabe (genus).
/// NCBI TaxId: 646628
/// </summary>
public abstract class Astrabe : Gobiidae, IAstrabe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astrabe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 646628;

    /// <inheritdoc />
    public virtual string GenusName => "Astrabe";

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
