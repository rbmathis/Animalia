using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Polyprionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Polyprionidae.Stereolepis;

/// <summary>
/// Abstract class for Stereolepis (genus).
/// NCBI TaxId: 184448
/// </summary>
public abstract class Stereolepis : Polyprionidae, IStereolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stereolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 184448;

    /// <inheritdoc />
    public virtual string GenusName => "Stereolepis";

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
