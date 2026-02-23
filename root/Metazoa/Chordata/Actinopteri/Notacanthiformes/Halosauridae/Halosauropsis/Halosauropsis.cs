using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Halosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Halosauridae.Halosauropsis;

/// <summary>
/// Abstract class for Halosauropsis (genus).
/// NCBI TaxId: 473368
/// </summary>
public abstract class Halosauropsis : Halosauridae, IHalosauropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halosauropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473368;

    /// <inheritdoc />
    public virtual string GenusName => "Halosauropsis";

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
