using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Notemigonus;

/// <summary>
/// Abstract class for Notemigonus (genus).
/// NCBI TaxId: 28799
/// </summary>
public abstract class Notemigonus : Leuciscidae, INotemigonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notemigonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28799;

    /// <inheritdoc />
    public virtual string GenusName => "Notemigonus";

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
