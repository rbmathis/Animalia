using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Pollachius;

/// <summary>
/// Abstract class for Pollachius (genus).
/// NCBI TaxId: 8059
/// </summary>
public abstract class Pollachius : Gadidae, IPollachius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pollachius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8059;

    /// <inheritdoc />
    public virtual string GenusName => "Pollachius";

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
