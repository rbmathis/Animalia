using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Dawkinsia;

/// <summary>
/// Abstract class for Dawkinsia (genus).
/// NCBI TaxId: 1278293
/// </summary>
public abstract class Dawkinsia : Cyprinidae, IDawkinsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dawkinsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1278293;

    /// <inheritdoc />
    public virtual string GenusName => "Dawkinsia";

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
