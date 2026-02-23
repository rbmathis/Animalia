using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathymasteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathymasteridae.Rathbunella;

/// <summary>
/// Abstract class for Rathbunella (genus).
/// NCBI TaxId: 301821
/// </summary>
public abstract class Rathbunella : Bathymasteridae, IRathbunella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rathbunella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 301821;

    /// <inheritdoc />
    public virtual string GenusName => "Rathbunella";

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
