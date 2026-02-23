using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Notosudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Notosudidae.Ahliesaurus;

/// <summary>
/// Abstract class for Ahliesaurus (genus).
/// NCBI TaxId: 509770
/// </summary>
public abstract class Ahliesaurus : Notosudidae, IAhliesaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ahliesaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 509770;

    /// <inheritdoc />
    public virtual string GenusName => "Ahliesaurus";

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
