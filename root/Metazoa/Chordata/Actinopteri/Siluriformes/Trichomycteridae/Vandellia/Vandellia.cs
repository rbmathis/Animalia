using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Vandellia;

/// <summary>
/// Abstract class for Vandellia (genus).
/// NCBI TaxId: 648150
/// </summary>
public abstract class Vandellia : Trichomycteridae, IVandellia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vandellia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 648150;

    /// <inheritdoc />
    public virtual string GenusName => "Vandellia";

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
