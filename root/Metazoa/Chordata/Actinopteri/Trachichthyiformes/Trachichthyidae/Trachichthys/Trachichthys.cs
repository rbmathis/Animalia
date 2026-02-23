using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae.Trachichthys;

/// <summary>
/// Abstract class for Trachichthys (genus).
/// NCBI TaxId: 3056101
/// </summary>
public abstract class Trachichthys : Trachichthyidae, ITrachichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3056101;

    /// <inheritdoc />
    public virtual string GenusName => "Trachichthys";

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
