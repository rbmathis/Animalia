using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Osteochilichthys;

/// <summary>
/// Abstract class for Osteochilichthys (genus).
/// NCBI TaxId: 1606677
/// </summary>
public abstract class Osteochilichthys : Cyprinidae, IOsteochilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Osteochilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1606677;

    /// <inheritdoc />
    public virtual string GenusName => "Osteochilichthys";

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
