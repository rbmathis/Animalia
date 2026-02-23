using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Nedystoma;

/// <summary>
/// Abstract class for Nedystoma (genus).
/// NCBI TaxId: 591329
/// </summary>
public abstract class Nedystoma : Ariidae, INedystoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nedystoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 591329;

    /// <inheritdoc />
    public virtual string GenusName => "Nedystoma";

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
