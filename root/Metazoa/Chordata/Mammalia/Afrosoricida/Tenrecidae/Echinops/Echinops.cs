using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Echinops;

/// <summary>
/// Abstract class for Echinops (genus).
/// NCBI TaxId: 9370
/// </summary>
public abstract class Echinops : Tenrecidae, IEchinops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echinops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9370;

    /// <inheritdoc />
    public virtual string GenusName => "Echinops";

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
