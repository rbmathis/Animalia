using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Erythrinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Erythrinidae.Hoplias;

/// <summary>
/// Abstract class for Hoplias (genus).
/// NCBI TaxId: 27719
/// </summary>
public abstract class Hoplias : Erythrinidae, IHoplias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27719;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplias";

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
