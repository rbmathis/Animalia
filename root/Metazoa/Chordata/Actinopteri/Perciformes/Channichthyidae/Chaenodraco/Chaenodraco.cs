using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae.Chaenodraco;

/// <summary>
/// Abstract class for Chaenodraco (genus).
/// NCBI TaxId: 70439
/// </summary>
public abstract class Chaenodraco : Channichthyidae, IChaenodraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaenodraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70439;

    /// <inheritdoc />
    public virtual string GenusName => "Chaenodraco";

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
