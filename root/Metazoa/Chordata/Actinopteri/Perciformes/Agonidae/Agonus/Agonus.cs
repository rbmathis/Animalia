using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Agonus;

/// <summary>
/// Abstract class for Agonus (genus).
/// NCBI TaxId: 508606
/// </summary>
public abstract class Agonus : Agonidae, IAgonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 508606;

    /// <inheritdoc />
    public virtual string GenusName => "Agonus";

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
