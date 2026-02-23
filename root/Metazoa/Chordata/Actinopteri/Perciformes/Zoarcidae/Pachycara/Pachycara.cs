using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Pachycara;

/// <summary>
/// Abstract class for Pachycara (genus).
/// NCBI TaxId: 36220
/// </summary>
public abstract class Pachycara : Zoarcidae, IPachycara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachycara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36220;

    /// <inheritdoc />
    public virtual string GenusName => "Pachycara";

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
