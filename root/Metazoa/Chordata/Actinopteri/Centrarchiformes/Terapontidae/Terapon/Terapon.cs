using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Terapon;

/// <summary>
/// Abstract class for Terapon (genus).
/// NCBI TaxId: 163130
/// </summary>
public abstract class Terapon : Terapontidae, ITerapon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Terapon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163130;

    /// <inheritdoc />
    public virtual string GenusName => "Terapon";

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
