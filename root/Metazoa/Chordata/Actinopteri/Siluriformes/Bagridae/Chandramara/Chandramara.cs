using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Chandramara;

/// <summary>
/// Abstract class for Chandramara (genus).
/// NCBI TaxId: 1080465
/// </summary>
public abstract class Chandramara : Bagridae, IChandramara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chandramara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1080465;

    /// <inheritdoc />
    public virtual string GenusName => "Chandramara";

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
