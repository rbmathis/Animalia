using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Leptolebias;

/// <summary>
/// Abstract class for Leptolebias (genus).
/// NCBI TaxId: 52671
/// </summary>
public abstract class Leptolebias : Rivulidae, ILeptolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52671;

    /// <inheritdoc />
    public virtual string GenusName => "Leptolebias";

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
