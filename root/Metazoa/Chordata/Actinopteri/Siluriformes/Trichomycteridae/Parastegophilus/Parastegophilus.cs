using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Parastegophilus;

/// <summary>
/// Abstract class for Parastegophilus (genus).
/// NCBI TaxId: 648136
/// </summary>
public abstract class Parastegophilus : Trichomycteridae, IParastegophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parastegophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 648136;

    /// <inheritdoc />
    public virtual string GenusName => "Parastegophilus";

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
