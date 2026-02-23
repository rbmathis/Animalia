using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Hypodytes;

/// <summary>
/// Abstract class for Hypodytes (genus).
/// NCBI TaxId: 337884
/// </summary>
public abstract class Hypodytes : Tetrarogidae, IHypodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337884;

    /// <inheritdoc />
    public virtual string GenusName => "Hypodytes";

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
