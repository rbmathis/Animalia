using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Budorcas;

/// <summary>
/// Abstract class for Budorcas (genus).
/// NCBI TaxId: 37180
/// </summary>
public abstract class Budorcas : Bovidae, IBudorcas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Budorcas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37180;

    /// <inheritdoc />
    public virtual string GenusName => "Budorcas";

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
