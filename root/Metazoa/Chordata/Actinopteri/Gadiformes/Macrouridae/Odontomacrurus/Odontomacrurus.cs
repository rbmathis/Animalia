using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Odontomacrurus;

/// <summary>
/// Abstract class for Odontomacrurus (genus).
/// NCBI TaxId: 473377
/// </summary>
public abstract class Odontomacrurus : Macrouridae, IOdontomacrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontomacrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473377;

    /// <inheritdoc />
    public virtual string GenusName => "Odontomacrurus";

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
