using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Pantholops;

/// <summary>
/// Abstract class for Pantholops (genus).
/// NCBI TaxId: 59537
/// </summary>
public abstract class Pantholops : Bovidae, IPantholops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pantholops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59537;

    /// <inheritdoc />
    public virtual string GenusName => "Pantholops";

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
