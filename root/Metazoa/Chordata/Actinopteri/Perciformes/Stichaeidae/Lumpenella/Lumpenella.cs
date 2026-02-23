using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Lumpenella;

/// <summary>
/// Abstract class for Lumpenella (genus).
/// NCBI TaxId: 557407
/// </summary>
public abstract class Lumpenella : Stichaeidae, ILumpenella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lumpenella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 557407;

    /// <inheritdoc />
    public virtual string GenusName => "Lumpenella";

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
