using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Grammoplites;

/// <summary>
/// Abstract class for Grammoplites (genus).
/// NCBI TaxId: 490325
/// </summary>
public abstract class Grammoplites : Platycephalidae, IGrammoplites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grammoplites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490325;

    /// <inheritdoc />
    public virtual string GenusName => "Grammoplites";

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
