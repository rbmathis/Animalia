using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Candoia;

/// <summary>
/// Abstract class for Candoia (genus).
/// NCBI TaxId: 51852
/// </summary>
public abstract class Candoia : Boidae, ICandoia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Candoia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51852;

    /// <inheritdoc />
    public virtual string GenusName => "Candoia";

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
