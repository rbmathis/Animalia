using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Llanolebias;

/// <summary>
/// Abstract class for Llanolebias (genus).
/// NCBI TaxId: 449247
/// </summary>
public abstract class Llanolebias : Rivulidae, ILlanolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Llanolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 449247;

    /// <inheritdoc />
    public virtual string GenusName => "Llanolebias";

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
