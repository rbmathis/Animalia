using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae.Aulotrachichthys;

/// <summary>
/// Abstract class for Aulotrachichthys (genus).
/// NCBI TaxId: 390683
/// </summary>
public abstract class Aulotrachichthys : Trachichthyidae, IAulotrachichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aulotrachichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390683;

    /// <inheritdoc />
    public virtual string GenusName => "Aulotrachichthys";

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
