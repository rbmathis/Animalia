using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Nautichthys;

/// <summary>
/// Abstract class for Nautichthys (genus).
/// NCBI TaxId: 274771
/// </summary>
public abstract class Nautichthys : Agonidae, INautichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nautichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274771;

    /// <inheritdoc />
    public virtual string GenusName => "Nautichthys";

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
