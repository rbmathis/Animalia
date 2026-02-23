using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Parazacco;

/// <summary>
/// Abstract class for Parazacco (genus).
/// NCBI TaxId: 327402
/// </summary>
public abstract class Parazacco : Xenocyprididae, IParazacco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parazacco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 327402;

    /// <inheritdoc />
    public virtual string GenusName => "Parazacco";

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
