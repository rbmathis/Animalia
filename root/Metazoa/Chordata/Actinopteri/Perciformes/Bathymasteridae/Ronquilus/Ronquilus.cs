using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathymasteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathymasteridae.Ronquilus;

/// <summary>
/// Abstract class for Ronquilus (genus).
/// NCBI TaxId: 428029
/// </summary>
public abstract class Ronquilus : Bathymasteridae, IRonquilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ronquilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 428029;

    /// <inheritdoc />
    public virtual string GenusName => "Ronquilus";

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
