using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Austrolebias;

/// <summary>
/// Abstract class for Austrolebias (genus).
/// NCBI TaxId: 308056
/// </summary>
public abstract class Austrolebias : Rivulidae, IAustrolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Austrolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 308056;

    /// <inheritdoc />
    public virtual string GenusName => "Austrolebias";

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
