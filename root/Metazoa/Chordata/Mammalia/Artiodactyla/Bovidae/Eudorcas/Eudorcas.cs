using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Eudorcas;

/// <summary>
/// Abstract class for Eudorcas (genus).
/// NCBI TaxId: 936348
/// </summary>
public abstract class Eudorcas : Bovidae, IEudorcas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eudorcas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 936348;

    /// <inheritdoc />
    public virtual string GenusName => "Eudorcas";

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
