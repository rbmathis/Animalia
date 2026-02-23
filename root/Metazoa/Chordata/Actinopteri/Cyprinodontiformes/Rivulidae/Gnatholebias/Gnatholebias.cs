using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Gnatholebias;

/// <summary>
/// Abstract class for Gnatholebias (genus).
/// NCBI TaxId: 135310
/// </summary>
public abstract class Gnatholebias : Rivulidae, IGnatholebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gnatholebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135310;

    /// <inheritdoc />
    public virtual string GenusName => "Gnatholebias";

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
