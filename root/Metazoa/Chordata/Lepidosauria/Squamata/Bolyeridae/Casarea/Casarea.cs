using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Bolyeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Bolyeridae.Casarea;

/// <summary>
/// Abstract class for Casarea (genus).
/// NCBI TaxId: 51856
/// </summary>
public abstract class Casarea : Bolyeridae, ICasarea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Casarea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51856;

    /// <inheritdoc />
    public virtual string GenusName => "Casarea";

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
