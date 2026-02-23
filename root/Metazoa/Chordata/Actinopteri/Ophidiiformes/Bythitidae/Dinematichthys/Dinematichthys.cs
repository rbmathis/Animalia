using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Dinematichthys;

/// <summary>
/// Abstract class for Dinematichthys (genus).
/// NCBI TaxId: 1147080
/// </summary>
public abstract class Dinematichthys : Bythitidae, IDinematichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dinematichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1147080;

    /// <inheritdoc />
    public virtual string GenusName => "Dinematichthys";

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
