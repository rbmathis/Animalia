using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Alfaro;

/// <summary>
/// Abstract class for Alfaro (genus).
/// NCBI TaxId: 32461
/// </summary>
public abstract class Alfaro : Poeciliidae, IAlfaro
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alfaro";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32461;

    /// <inheritdoc />
    public virtual string GenusName => "Alfaro";

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
