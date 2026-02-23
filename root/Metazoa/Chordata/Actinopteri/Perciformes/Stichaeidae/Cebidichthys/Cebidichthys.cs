using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Cebidichthys;

/// <summary>
/// Abstract class for Cebidichthys (genus).
/// NCBI TaxId: 271502
/// </summary>
public abstract class Cebidichthys : Stichaeidae, ICebidichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cebidichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 271502;

    /// <inheritdoc />
    public virtual string GenusName => "Cebidichthys";

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
