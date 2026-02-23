using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Naemorhedus;

/// <summary>
/// Abstract class for Naemorhedus (genus).
/// NCBI TaxId: 34870
/// </summary>
public abstract class Naemorhedus : Bovidae, INaemorhedus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Naemorhedus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34870;

    /// <inheritdoc />
    public virtual string GenusName => "Naemorhedus";

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
