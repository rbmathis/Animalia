using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Kantaka;

/// <summary>
/// Abstract class for Kantaka (genus).
/// NCBI TaxId: 2899770
/// </summary>
public abstract class Kantaka : Cyprinidae, IKantaka
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kantaka";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2899770;

    /// <inheritdoc />
    public virtual string GenusName => "Kantaka";

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
