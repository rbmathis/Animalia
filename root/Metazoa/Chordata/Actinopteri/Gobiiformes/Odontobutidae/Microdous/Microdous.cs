using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae.Microdous;

/// <summary>
/// Abstract class for Microdous (genus).
/// NCBI TaxId: 2507735
/// </summary>
public abstract class Microdous : Odontobutidae, IMicrodous
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microdous";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2507735;

    /// <inheritdoc />
    public virtual string GenusName => "Microdous";

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
