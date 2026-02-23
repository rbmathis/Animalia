using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Ninurta;

/// <summary>
/// Abstract class for Ninurta (genus).
/// NCBI TaxId: 885431
/// </summary>
public abstract class Ninurta : Cordylidae, INinurta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ninurta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 885431;

    /// <inheritdoc />
    public virtual string GenusName => "Ninurta";

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
