using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Latridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Latridae.Latris;

/// <summary>
/// Abstract class for Latris (genus).
/// NCBI TaxId: 97161
/// </summary>
public abstract class Latris : Latridae, ILatris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Latris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 97161;

    /// <inheritdoc />
    public virtual string GenusName => "Latris";

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
