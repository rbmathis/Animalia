using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Neoscopelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Neoscopelidae.Solivomer;

/// <summary>
/// Abstract class for Solivomer (genus).
/// NCBI TaxId: 1069379
/// </summary>
public abstract class Solivomer : Neoscopelidae, ISolivomer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Solivomer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1069379;

    /// <inheritdoc />
    public virtual string GenusName => "Solivomer";

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
