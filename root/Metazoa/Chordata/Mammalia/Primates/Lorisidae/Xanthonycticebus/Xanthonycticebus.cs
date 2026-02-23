using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae.Xanthonycticebus;

/// <summary>
/// Abstract class for Xanthonycticebus (genus).
/// NCBI TaxId: 3030685
/// </summary>
public abstract class Xanthonycticebus : Lorisidae, IXanthonycticebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xanthonycticebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3030685;

    /// <inheritdoc />
    public virtual string GenusName => "Xanthonycticebus";

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
