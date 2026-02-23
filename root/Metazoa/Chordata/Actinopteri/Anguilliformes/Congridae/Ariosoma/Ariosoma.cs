using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Ariosoma;

/// <summary>
/// Abstract class for Ariosoma (genus).
/// NCBI TaxId: 135219
/// </summary>
public abstract class Ariosoma : Congridae, IAriosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ariosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135219;

    /// <inheritdoc />
    public virtual string GenusName => "Ariosoma";

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
