using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Sinogastromyzon;

/// <summary>
/// Abstract class for Sinogastromyzon (genus).
/// NCBI TaxId: 241450
/// </summary>
public abstract class Sinogastromyzon : Balitoridae, ISinogastromyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sinogastromyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241450;

    /// <inheritdoc />
    public virtual string GenusName => "Sinogastromyzon";

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
