using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Pterygotrigla;

/// <summary>
/// Abstract class for Pterygotrigla (genus).
/// NCBI TaxId: 334938
/// </summary>
public abstract class Pterygotrigla : Triglidae, IPterygotrigla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterygotrigla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334938;

    /// <inheritdoc />
    public virtual string GenusName => "Pterygotrigla";

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
