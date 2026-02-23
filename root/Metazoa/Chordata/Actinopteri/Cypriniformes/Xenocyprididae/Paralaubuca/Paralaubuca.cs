using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Paralaubuca;

/// <summary>
/// Abstract class for Paralaubuca (genus).
/// NCBI TaxId: 516035
/// </summary>
public abstract class Paralaubuca : Xenocyprididae, IParalaubuca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paralaubuca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 516035;

    /// <inheritdoc />
    public virtual string GenusName => "Paralaubuca";

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
