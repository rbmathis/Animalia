using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Blicca;

/// <summary>
/// Abstract class for Blicca (genus).
/// NCBI TaxId: 58316
/// </summary>
public abstract class Blicca : Leuciscidae, IBlicca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Blicca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58316;

    /// <inheritdoc />
    public virtual string GenusName => "Blicca";

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
