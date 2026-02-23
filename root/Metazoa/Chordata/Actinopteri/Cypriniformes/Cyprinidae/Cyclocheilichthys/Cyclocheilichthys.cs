using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyclocheilichthys;

/// <summary>
/// Abstract class for Cyclocheilichthys (genus).
/// NCBI TaxId: 137768
/// </summary>
public abstract class Cyclocheilichthys : Cyprinidae, ICyclocheilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclocheilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137768;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclocheilichthys";

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
