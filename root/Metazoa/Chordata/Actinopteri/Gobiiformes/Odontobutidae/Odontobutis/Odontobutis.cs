using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae.Odontobutis;

/// <summary>
/// Abstract class for Odontobutis (genus).
/// NCBI TaxId: 86243
/// </summary>
public abstract class Odontobutis : Odontobutidae, IOdontobutis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontobutis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86243;

    /// <inheritdoc />
    public virtual string GenusName => "Odontobutis";

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
