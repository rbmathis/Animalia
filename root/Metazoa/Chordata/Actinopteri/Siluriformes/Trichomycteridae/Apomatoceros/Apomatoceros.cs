using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Apomatoceros;

/// <summary>
/// Abstract class for Apomatoceros (genus).
/// NCBI TaxId: 648128
/// </summary>
public abstract class Apomatoceros : Trichomycteridae, IApomatoceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apomatoceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 648128;

    /// <inheritdoc />
    public virtual string GenusName => "Apomatoceros";

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
