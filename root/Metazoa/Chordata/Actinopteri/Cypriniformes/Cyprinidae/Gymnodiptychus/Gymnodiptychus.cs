using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Gymnodiptychus;

/// <summary>
/// Abstract class for Gymnodiptychus (genus).
/// NCBI TaxId: 263533
/// </summary>
public abstract class Gymnodiptychus : Cyprinidae, IGymnodiptychus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnodiptychus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 263533;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnodiptychus";

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
