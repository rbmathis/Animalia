using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Bidenichthys;

/// <summary>
/// Abstract class for Bidenichthys (genus).
/// NCBI TaxId: 1311535
/// </summary>
public abstract class Bidenichthys : Bythitidae, IBidenichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bidenichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1311535;

    /// <inheritdoc />
    public virtual string GenusName => "Bidenichthys";

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
