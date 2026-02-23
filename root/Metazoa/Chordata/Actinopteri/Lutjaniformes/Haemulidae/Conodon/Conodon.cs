using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Conodon;

/// <summary>
/// Abstract class for Conodon (genus).
/// NCBI TaxId: 722432
/// </summary>
public abstract class Conodon : Haemulidae, IConodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722432;

    /// <inheritdoc />
    public virtual string GenusName => "Conodon";

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
