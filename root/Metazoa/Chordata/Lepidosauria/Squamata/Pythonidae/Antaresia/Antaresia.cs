using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Antaresia;

/// <summary>
/// Abstract class for Antaresia (genus).
/// NCBI TaxId: 196249
/// </summary>
public abstract class Antaresia : Pythonidae, IAntaresia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Antaresia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 196249;

    /// <inheritdoc />
    public virtual string GenusName => "Antaresia";

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
