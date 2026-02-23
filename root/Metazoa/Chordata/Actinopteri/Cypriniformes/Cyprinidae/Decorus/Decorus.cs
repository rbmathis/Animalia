using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Decorus;

/// <summary>
/// Abstract class for Decorus (genus).
/// NCBI TaxId: 3363403
/// </summary>
public abstract class Decorus : Cyprinidae, IDecorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Decorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363403;

    /// <inheritdoc />
    public virtual string GenusName => "Decorus";

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
