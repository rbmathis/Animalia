using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Oplopomus;

/// <summary>
/// Abstract class for Oplopomus (genus).
/// NCBI TaxId: 622426
/// </summary>
public abstract class Oplopomus : Gobiidae, IOplopomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oplopomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 622426;

    /// <inheritdoc />
    public virtual string GenusName => "Oplopomus";

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
