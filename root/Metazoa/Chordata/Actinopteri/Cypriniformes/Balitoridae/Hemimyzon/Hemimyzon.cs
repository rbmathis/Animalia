using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Hemimyzon;

/// <summary>
/// Abstract class for Hemimyzon (genus).
/// NCBI TaxId: 241457
/// </summary>
public abstract class Hemimyzon : Balitoridae, IHemimyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemimyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241457;

    /// <inheritdoc />
    public virtual string GenusName => "Hemimyzon";

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
