using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Barbichthys;

/// <summary>
/// Abstract class for Barbichthys (genus).
/// NCBI TaxId: 643438
/// </summary>
public abstract class Barbichthys : Cyprinidae, IBarbichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barbichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643438;

    /// <inheritdoc />
    public virtual string GenusName => "Barbichthys";

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
