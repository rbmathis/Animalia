using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Bothrocarina;

/// <summary>
/// Abstract class for Bothrocarina (genus).
/// NCBI TaxId: 390673
/// </summary>
public abstract class Bothrocarina : Zoarcidae, IBothrocarina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bothrocarina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390673;

    /// <inheritdoc />
    public virtual string GenusName => "Bothrocarina";

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
