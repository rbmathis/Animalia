using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mephitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mephitidae.Conepatus;

/// <summary>
/// Abstract class for Conepatus (genus).
/// NCBI TaxId: 30541
/// </summary>
public abstract class Conepatus : Mephitidae, IConepatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conepatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30541;

    /// <inheritdoc />
    public virtual string GenusName => "Conepatus";

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
