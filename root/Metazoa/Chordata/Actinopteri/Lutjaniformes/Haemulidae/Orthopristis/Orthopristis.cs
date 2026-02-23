using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Orthopristis;

/// <summary>
/// Abstract class for Orthopristis (genus).
/// NCBI TaxId: 482918
/// </summary>
public abstract class Orthopristis : Haemulidae, IOrthopristis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orthopristis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 482918;

    /// <inheritdoc />
    public virtual string GenusName => "Orthopristis";

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
