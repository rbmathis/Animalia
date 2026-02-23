using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Opisthocentrus;

/// <summary>
/// Abstract class for Opisthocentrus (genus).
/// NCBI TaxId: 476927
/// </summary>
public abstract class Opisthocentrus : Stichaeidae, IOpisthocentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opisthocentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 476927;

    /// <inheritdoc />
    public virtual string GenusName => "Opisthocentrus";

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
