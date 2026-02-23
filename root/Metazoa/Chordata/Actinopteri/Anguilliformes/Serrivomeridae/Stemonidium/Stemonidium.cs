using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Serrivomeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Serrivomeridae.Stemonidium;

/// <summary>
/// Abstract class for Stemonidium (genus).
/// NCBI TaxId: 87099
/// </summary>
public abstract class Stemonidium : Serrivomeridae, IStemonidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stemonidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 87099;

    /// <inheritdoc />
    public virtual string GenusName => "Stemonidium";

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
