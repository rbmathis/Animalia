using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Azygopterus;

/// <summary>
/// Abstract class for Azygopterus (genus).
/// NCBI TaxId: 1317006
/// </summary>
public abstract class Azygopterus : Stichaeidae, IAzygopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Azygopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1317006;

    /// <inheritdoc />
    public virtual string GenusName => "Azygopterus";

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
