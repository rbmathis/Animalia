using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Campellolebias;

/// <summary>
/// Abstract class for Campellolebias (genus).
/// NCBI TaxId: 60337
/// </summary>
public abstract class Campellolebias : Rivulidae, ICampellolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Campellolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 60337;

    /// <inheritdoc />
    public virtual string GenusName => "Campellolebias";

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
