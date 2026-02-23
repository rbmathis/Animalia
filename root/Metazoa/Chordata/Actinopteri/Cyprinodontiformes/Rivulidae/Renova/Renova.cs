using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Renova;

/// <summary>
/// Abstract class for Renova (genus).
/// NCBI TaxId: 61833
/// </summary>
public abstract class Renova : Rivulidae, IRenova
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Renova";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61833;

    /// <inheritdoc />
    public virtual string GenusName => "Renova";

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
