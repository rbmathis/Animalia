using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Barbonymus;

/// <summary>
/// Abstract class for Barbonymus (genus).
/// NCBI TaxId: 270004
/// </summary>
public abstract class Barbonymus : Cyprinidae, IBarbonymus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barbonymus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270004;

    /// <inheritdoc />
    public virtual string GenusName => "Barbonymus";

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
