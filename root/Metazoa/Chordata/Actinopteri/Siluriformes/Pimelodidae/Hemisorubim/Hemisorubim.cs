using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Hemisorubim;

/// <summary>
/// Abstract class for Hemisorubim (genus).
/// NCBI TaxId: 742452
/// </summary>
public abstract class Hemisorubim : Pimelodidae, IHemisorubim
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemisorubim";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 742452;

    /// <inheritdoc />
    public virtual string GenusName => "Hemisorubim";

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
