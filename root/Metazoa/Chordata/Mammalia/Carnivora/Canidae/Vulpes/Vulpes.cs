using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Vulpes;

/// <summary>
/// Abstract class for Vulpes (genus).
/// NCBI TaxId: 9625
/// </summary>
public abstract class Vulpes : Canidae, IVulpes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vulpes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9625;

    /// <inheritdoc />
    public virtual string GenusName => "Vulpes";

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
