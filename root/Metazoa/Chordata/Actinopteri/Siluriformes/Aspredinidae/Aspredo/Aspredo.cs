using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Aspredo;

/// <summary>
/// Abstract class for Aspredo (genus).
/// NCBI TaxId: 1312653
/// </summary>
public abstract class Aspredo : Aspredinidae, IAspredo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspredo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1312653;

    /// <inheritdoc />
    public virtual string GenusName => "Aspredo";

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
