using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Dzihunia;

/// <summary>
/// Abstract class for Dzihunia (genus).
/// NCBI TaxId: 2814119
/// </summary>
public abstract class Dzihunia : Nemacheilidae, IDzihunia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dzihunia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2814119;

    /// <inheritdoc />
    public virtual string GenusName => "Dzihunia";

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
