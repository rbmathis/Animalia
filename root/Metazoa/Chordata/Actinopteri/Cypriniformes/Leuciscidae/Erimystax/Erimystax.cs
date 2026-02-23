using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Erimystax;

/// <summary>
/// Abstract class for Erimystax (genus).
/// NCBI TaxId: 85565
/// </summary>
public abstract class Erimystax : Leuciscidae, IErimystax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erimystax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 85565;

    /// <inheritdoc />
    public virtual string GenusName => "Erimystax";

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
