using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae.Micropercops;

/// <summary>
/// Abstract class for Micropercops (genus).
/// NCBI TaxId: 86240
/// </summary>
public abstract class Micropercops : Odontobutidae, IMicropercops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micropercops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86240;

    /// <inheritdoc />
    public virtual string GenusName => "Micropercops";

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
