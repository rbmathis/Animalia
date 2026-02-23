using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Wertheimeria;

/// <summary>
/// Abstract class for Wertheimeria (genus).
/// NCBI TaxId: 1312672
/// </summary>
public abstract class Wertheimeria : Doradidae, IWertheimeria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wertheimeria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1312672;

    /// <inheritdoc />
    public virtual string GenusName => "Wertheimeria";

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
