using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Erromyzon;

/// <summary>
/// Abstract class for Erromyzon (genus).
/// NCBI TaxId: 643426
/// </summary>
public abstract class Erromyzon : Gastromyzontidae, IErromyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erromyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643426;

    /// <inheritdoc />
    public virtual string GenusName => "Erromyzon";

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
