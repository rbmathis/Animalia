using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Eupetaurus;

/// <summary>
/// Abstract class for Eupetaurus (genus).
/// NCBI TaxId: 226698
/// </summary>
public abstract class Eupetaurus : Sciuridae, IEupetaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eupetaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226698;

    /// <inheritdoc />
    public virtual string GenusName => "Eupetaurus";

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
