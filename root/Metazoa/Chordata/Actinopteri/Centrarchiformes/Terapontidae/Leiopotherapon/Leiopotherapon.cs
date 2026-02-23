using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Leiopotherapon;

/// <summary>
/// Abstract class for Leiopotherapon (genus).
/// NCBI TaxId: 317032
/// </summary>
public abstract class Leiopotherapon : Terapontidae, ILeiopotherapon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiopotherapon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 317032;

    /// <inheritdoc />
    public virtual string GenusName => "Leiopotherapon";

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
