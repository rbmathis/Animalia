using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Atopodontus;

/// <summary>
/// Abstract class for Atopodontus (genus).
/// NCBI TaxId: 2922176
/// </summary>
public abstract class Atopodontus : Mochokidae, IAtopodontus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atopodontus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2922176;

    /// <inheritdoc />
    public virtual string GenusName => "Atopodontus";

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
