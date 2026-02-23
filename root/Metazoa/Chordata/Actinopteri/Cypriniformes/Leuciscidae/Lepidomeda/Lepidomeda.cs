using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Lepidomeda;

/// <summary>
/// Abstract class for Lepidomeda (genus).
/// NCBI TaxId: 67544
/// </summary>
public abstract class Lepidomeda : Leuciscidae, ILepidomeda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidomeda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 67544;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidomeda";

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
