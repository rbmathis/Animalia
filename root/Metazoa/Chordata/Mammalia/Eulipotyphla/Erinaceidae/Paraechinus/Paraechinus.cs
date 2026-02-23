using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Paraechinus;

/// <summary>
/// Abstract class for Paraechinus (genus).
/// NCBI TaxId: 30579
/// </summary>
public abstract class Paraechinus : Erinaceidae, IParaechinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraechinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30579;

    /// <inheritdoc />
    public virtual string GenusName => "Paraechinus";

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
