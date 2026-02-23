using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Eirmotus;

/// <summary>
/// Abstract class for Eirmotus (genus).
/// NCBI TaxId: 643454
/// </summary>
public abstract class Eirmotus : Cyprinidae, IEirmotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eirmotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643454;

    /// <inheritdoc />
    public virtual string GenusName => "Eirmotus";

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
