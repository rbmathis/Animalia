using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Gorgasia;

/// <summary>
/// Abstract class for Gorgasia (genus).
/// NCBI TaxId: 189486
/// </summary>
public abstract class Gorgasia : Congridae, IGorgasia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gorgasia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189486;

    /// <inheritdoc />
    public virtual string GenusName => "Gorgasia";

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
