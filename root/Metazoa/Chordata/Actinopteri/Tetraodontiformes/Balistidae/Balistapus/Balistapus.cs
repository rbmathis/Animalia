using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Balistapus;

/// <summary>
/// Abstract class for Balistapus (genus).
/// NCBI TaxId: 392898
/// </summary>
public abstract class Balistapus : Balistidae, IBalistapus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Balistapus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 392898;

    /// <inheritdoc />
    public virtual string GenusName => "Balistapus";

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
