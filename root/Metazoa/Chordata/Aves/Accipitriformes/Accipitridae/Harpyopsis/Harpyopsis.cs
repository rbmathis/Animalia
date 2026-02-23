using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Harpyopsis;

/// <summary>
/// Abstract class for Harpyopsis (genus).
/// NCBI TaxId: 321107
/// </summary>
public abstract class Harpyopsis : Accipitridae, IHarpyopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Harpyopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321107;

    /// <inheritdoc />
    public virtual string GenusName => "Harpyopsis";

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
