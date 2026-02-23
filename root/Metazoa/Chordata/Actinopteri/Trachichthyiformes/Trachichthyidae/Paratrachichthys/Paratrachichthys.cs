using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae.Paratrachichthys;

/// <summary>
/// Abstract class for Paratrachichthys (genus).
/// NCBI TaxId: 443799
/// </summary>
public abstract class Paratrachichthys : Trachichthyidae, IParatrachichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paratrachichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443799;

    /// <inheritdoc />
    public virtual string GenusName => "Paratrachichthys";

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
