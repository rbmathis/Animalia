using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Huso;

/// <summary>
/// Abstract class for Huso (genus).
/// NCBI TaxId: 55292
/// </summary>
public abstract class Huso : Acipenseridae, IHuso
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Huso";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55292;

    /// <inheritdoc />
    public virtual string GenusName => "Huso";

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
