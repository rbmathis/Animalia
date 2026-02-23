using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Plectorhinchus;

/// <summary>
/// Abstract class for Plectorhinchus (genus).
/// NCBI TaxId: 349641
/// </summary>
public abstract class Plectorhinchus : Haemulidae, IPlectorhinchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plectorhinchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 349641;

    /// <inheritdoc />
    public virtual string GenusName => "Plectorhinchus";

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
