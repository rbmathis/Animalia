using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Gymnostomus;

/// <summary>
/// Abstract class for Gymnostomus (genus).
/// NCBI TaxId: 1906138
/// </summary>
public abstract class Gymnostomus : Cyprinidae, IGymnostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1906138;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnostomus";

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
