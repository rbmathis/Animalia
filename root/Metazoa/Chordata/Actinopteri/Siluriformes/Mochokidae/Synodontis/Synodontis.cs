using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Synodontis;

/// <summary>
/// Abstract class for Synodontis (genus).
/// NCBI TaxId: 42509
/// </summary>
public abstract class Synodontis : Mochokidae, ISynodontis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synodontis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42509;

    /// <inheritdoc />
    public virtual string GenusName => "Synodontis";

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
