using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Lepidotrigla;

/// <summary>
/// Abstract class for Lepidotrigla (genus).
/// NCBI TaxId: 255556
/// </summary>
public abstract class Lepidotrigla : Triglidae, ILepidotrigla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidotrigla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255556;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidotrigla";

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
