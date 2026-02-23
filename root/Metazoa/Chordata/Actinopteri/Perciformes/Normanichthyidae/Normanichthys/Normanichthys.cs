using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Normanichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Normanichthyidae.Normanichthys;

/// <summary>
/// Abstract class for Normanichthys (genus).
/// NCBI TaxId: 275434
/// </summary>
public abstract class Normanichthys : Normanichthyidae, INormanichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Normanichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 275434;

    /// <inheritdoc />
    public virtual string GenusName => "Normanichthys";

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
