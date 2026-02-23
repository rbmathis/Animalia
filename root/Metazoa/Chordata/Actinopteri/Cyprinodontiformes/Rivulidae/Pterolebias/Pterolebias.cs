using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Pterolebias;

/// <summary>
/// Abstract class for Pterolebias (genus).
/// NCBI TaxId: 60340
/// </summary>
public abstract class Pterolebias : Rivulidae, IPterolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 60340;

    /// <inheritdoc />
    public virtual string GenusName => "Pterolebias";

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
