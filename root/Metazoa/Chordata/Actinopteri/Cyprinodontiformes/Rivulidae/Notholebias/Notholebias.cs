using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Notholebias;

/// <summary>
/// Abstract class for Notholebias (genus).
/// NCBI TaxId: 1380417
/// </summary>
public abstract class Notholebias : Rivulidae, INotholebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notholebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1380417;

    /// <inheritdoc />
    public virtual string GenusName => "Notholebias";

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
