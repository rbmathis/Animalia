using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Discogobio;

/// <summary>
/// Abstract class for Discogobio (genus).
/// NCBI TaxId: 172909
/// </summary>
public abstract class Discogobio : Cyprinidae, IDiscogobio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Discogobio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172909;

    /// <inheritdoc />
    public virtual string GenusName => "Discogobio";

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
