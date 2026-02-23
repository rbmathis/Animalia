using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Rhonciscus;

/// <summary>
/// Abstract class for Rhonciscus (genus).
/// NCBI TaxId: 2070549
/// </summary>
public abstract class Rhonciscus : Haemulidae, IRhonciscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhonciscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2070549;

    /// <inheritdoc />
    public virtual string GenusName => "Rhonciscus";

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
