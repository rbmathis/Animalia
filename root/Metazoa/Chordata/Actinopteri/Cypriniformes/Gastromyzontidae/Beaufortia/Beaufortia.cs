using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Beaufortia;

/// <summary>
/// Abstract class for Beaufortia (genus).
/// NCBI TaxId: 210584
/// </summary>
public abstract class Beaufortia : Gastromyzontidae, IBeaufortia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Beaufortia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210584;

    /// <inheritdoc />
    public virtual string GenusName => "Beaufortia";

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
