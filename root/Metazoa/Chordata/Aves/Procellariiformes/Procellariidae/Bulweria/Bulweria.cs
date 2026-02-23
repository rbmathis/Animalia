using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Bulweria;

/// <summary>
/// Abstract class for Bulweria (genus).
/// NCBI TaxId: 52119
/// </summary>
public abstract class Bulweria : Procellariidae, IBulweria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bulweria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52119;

    /// <inheritdoc />
    public virtual string GenusName => "Bulweria";

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
