using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Carasobarbus;

/// <summary>
/// Abstract class for Carasobarbus (genus).
/// NCBI TaxId: 467347
/// </summary>
public abstract class Carasobarbus : Cyprinidae, ICarasobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carasobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 467347;

    /// <inheritdoc />
    public virtual string GenusName => "Carasobarbus";

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
