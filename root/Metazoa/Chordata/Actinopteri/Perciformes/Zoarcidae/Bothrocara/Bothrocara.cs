using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Bothrocara;

/// <summary>
/// Abstract class for Bothrocara (genus).
/// NCBI TaxId: 153718
/// </summary>
public abstract class Bothrocara : Zoarcidae, IBothrocara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bothrocara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 153718;

    /// <inheritdoc />
    public virtual string GenusName => "Bothrocara";

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
