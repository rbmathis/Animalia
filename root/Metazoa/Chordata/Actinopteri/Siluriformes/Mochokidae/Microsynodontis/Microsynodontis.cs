using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Microsynodontis;

/// <summary>
/// Abstract class for Microsynodontis (genus).
/// NCBI TaxId: 390413
/// </summary>
public abstract class Microsynodontis : Mochokidae, IMicrosynodontis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microsynodontis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390413;

    /// <inheritdoc />
    public virtual string GenusName => "Microsynodontis";

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
