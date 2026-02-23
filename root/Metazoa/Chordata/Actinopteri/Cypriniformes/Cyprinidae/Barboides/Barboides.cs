using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Barboides;

/// <summary>
/// Abstract class for Barboides (genus).
/// NCBI TaxId: 432400
/// </summary>
public abstract class Barboides : Cyprinidae, IBarboides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barboides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432400;

    /// <inheritdoc />
    public virtual string GenusName => "Barboides";

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
