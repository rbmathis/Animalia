using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Bedotiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Bedotiidae.Rheocles;

/// <summary>
/// Abstract class for Rheocles (genus).
/// NCBI TaxId: 238697
/// </summary>
public abstract class Rheocles : Bedotiidae, IRheocles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rheocles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238697;

    /// <inheritdoc />
    public virtual string GenusName => "Rheocles";

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
