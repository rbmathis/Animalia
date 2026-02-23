using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae.Phocarctos;

/// <summary>
/// Abstract class for Phocarctos (genus).
/// NCBI TaxId: 34887
/// </summary>
public abstract class Phocarctos : Otariidae, IPhocarctos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phocarctos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34887;

    /// <inheritdoc />
    public virtual string GenusName => "Phocarctos";

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
