using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Aphrodroma;

/// <summary>
/// Abstract class for Aphrodroma (genus).
/// NCBI TaxId: 53663
/// </summary>
public abstract class Aphrodroma : Procellariidae, IAphrodroma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphrodroma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 53663;

    /// <inheritdoc />
    public virtual string GenusName => "Aphrodroma";

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
