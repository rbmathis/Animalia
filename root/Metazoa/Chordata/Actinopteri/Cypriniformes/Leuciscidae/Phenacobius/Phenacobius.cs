using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Phenacobius;

/// <summary>
/// Abstract class for Phenacobius (genus).
/// NCBI TaxId: 67551
/// </summary>
public abstract class Phenacobius : Leuciscidae, IPhenacobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phenacobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 67551;

    /// <inheritdoc />
    public virtual string GenusName => "Phenacobius";

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
