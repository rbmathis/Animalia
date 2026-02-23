using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Aspiorhynchus;

/// <summary>
/// Abstract class for Aspiorhynchus (genus).
/// NCBI TaxId: 748365
/// </summary>
public abstract class Aspiorhynchus : Cyprinidae, IAspiorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspiorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 748365;

    /// <inheritdoc />
    public virtual string GenusName => "Aspiorhynchus";

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
