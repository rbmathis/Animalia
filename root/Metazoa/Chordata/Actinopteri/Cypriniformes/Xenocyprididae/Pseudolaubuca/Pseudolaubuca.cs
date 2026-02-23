using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Pseudolaubuca;

/// <summary>
/// Abstract class for Pseudolaubuca (genus).
/// NCBI TaxId: 172913
/// </summary>
public abstract class Pseudolaubuca : Xenocyprididae, IPseudolaubuca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudolaubuca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172913;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudolaubuca";

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
