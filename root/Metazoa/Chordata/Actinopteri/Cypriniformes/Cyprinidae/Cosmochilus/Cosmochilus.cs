using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cosmochilus;

/// <summary>
/// Abstract class for Cosmochilus (genus).
/// NCBI TaxId: 643456
/// </summary>
public abstract class Cosmochilus : Cyprinidae, ICosmochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cosmochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643456;

    /// <inheritdoc />
    public virtual string GenusName => "Cosmochilus";

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
