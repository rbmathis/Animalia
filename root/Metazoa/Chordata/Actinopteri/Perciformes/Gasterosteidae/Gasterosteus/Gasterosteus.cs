using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Gasterosteus;

/// <summary>
/// Abstract class for Gasterosteus (genus).
/// NCBI TaxId: 69292
/// </summary>
public abstract class Gasterosteus : Gasterosteidae, IGasterosteus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gasterosteus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69292;

    /// <inheritdoc />
    public virtual string GenusName => "Gasterosteus";

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
