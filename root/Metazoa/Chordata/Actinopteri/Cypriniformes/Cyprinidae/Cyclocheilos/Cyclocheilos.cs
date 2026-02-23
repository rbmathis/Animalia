using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyclocheilos;

/// <summary>
/// Abstract class for Cyclocheilos (genus).
/// NCBI TaxId: 1906144
/// </summary>
public abstract class Cyclocheilos : Cyprinidae, ICyclocheilos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclocheilos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1906144;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclocheilos";

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
