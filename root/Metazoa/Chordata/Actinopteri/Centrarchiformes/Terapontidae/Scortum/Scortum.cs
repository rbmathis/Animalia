using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Scortum;

/// <summary>
/// Abstract class for Scortum (genus).
/// NCBI TaxId: 214430
/// </summary>
public abstract class Scortum : Terapontidae, IScortum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scortum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 214430;

    /// <inheritdoc />
    public virtual string GenusName => "Scortum";

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
