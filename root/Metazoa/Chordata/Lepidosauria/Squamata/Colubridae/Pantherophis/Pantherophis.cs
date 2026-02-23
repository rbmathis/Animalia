using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pantherophis;

/// <summary>
/// Abstract class for Pantherophis (genus).
/// NCBI TaxId: 201800
/// </summary>
public abstract class Pantherophis : Colubridae, IPantherophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pantherophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201800;

    /// <inheritdoc />
    public virtual string GenusName => "Pantherophis";

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
