using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae.Hipposideros;

/// <summary>
/// Abstract class for Hipposideros (genus).
/// NCBI TaxId: 58068
/// </summary>
public abstract class Hipposideros : Hipposideridae, IHipposideros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hipposideros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58068;

    /// <inheritdoc />
    public virtual string GenusName => "Hipposideros";

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
