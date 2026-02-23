using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Plicofollis;

/// <summary>
/// Abstract class for Plicofollis (genus).
/// NCBI TaxId: 435003
/// </summary>
public abstract class Plicofollis : Ariidae, IPlicofollis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plicofollis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 435003;

    /// <inheritdoc />
    public virtual string GenusName => "Plicofollis";

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
