using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae.Sorosichthys;

/// <summary>
/// Abstract class for Sorosichthys (genus).
/// NCBI TaxId: 1680632
/// </summary>
public abstract class Sorosichthys : Trachichthyidae, ISorosichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sorosichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1680632;

    /// <inheritdoc />
    public virtual string GenusName => "Sorosichthys";

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
