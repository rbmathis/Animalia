using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Napaeozapus;

/// <summary>
/// Abstract class for Napaeozapus (genus).
/// NCBI TaxId: 101670
/// </summary>
public abstract class Napaeozapus : Dipodidae, INapaeozapus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Napaeozapus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 101670;

    /// <inheritdoc />
    public virtual string GenusName => "Napaeozapus";

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
