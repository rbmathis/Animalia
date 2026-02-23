using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Erimonax;

/// <summary>
/// Abstract class for Erimonax (genus).
/// NCBI TaxId: 234870
/// </summary>
public abstract class Erimonax : Leuciscidae, IErimonax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erimonax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 234870;

    /// <inheritdoc />
    public virtual string GenusName => "Erimonax";

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
