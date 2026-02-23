using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Vomeridens;

/// <summary>
/// Abstract class for Vomeridens (genus).
/// NCBI TaxId: 691751
/// </summary>
public abstract class Vomeridens : Bathydraconidae, IVomeridens
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vomeridens";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 691751;

    /// <inheritdoc />
    public virtual string GenusName => "Vomeridens";

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
