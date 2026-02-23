using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Paracrossochilus;

/// <summary>
/// Abstract class for Paracrossochilus (genus).
/// NCBI TaxId: 432384
/// </summary>
public abstract class Paracrossochilus : Cyprinidae, IParacrossochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracrossochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432384;

    /// <inheritdoc />
    public virtual string GenusName => "Paracrossochilus";

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
