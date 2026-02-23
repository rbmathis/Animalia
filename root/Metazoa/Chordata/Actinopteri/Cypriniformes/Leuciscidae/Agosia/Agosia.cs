using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Agosia;

/// <summary>
/// Abstract class for Agosia (genus).
/// NCBI TaxId: 234875
/// </summary>
public abstract class Agosia : Leuciscidae, IAgosia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agosia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 234875;

    /// <inheritdoc />
    public virtual string GenusName => "Agosia";

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
