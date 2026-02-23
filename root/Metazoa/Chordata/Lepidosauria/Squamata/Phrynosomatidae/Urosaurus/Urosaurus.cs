using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Urosaurus;

/// <summary>
/// Abstract class for Urosaurus (genus).
/// NCBI TaxId: 43646
/// </summary>
public abstract class Urosaurus : Phrynosomatidae, IUrosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43646;

    /// <inheritdoc />
    public virtual string GenusName => "Urosaurus";

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
