using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Diaphorapteryx;

/// <summary>
/// Abstract class for Diaphorapteryx (genus).
/// NCBI TaxId: 1294539
/// </summary>
public abstract class Diaphorapteryx : Rallidae, IDiaphorapteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diaphorapteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1294539;

    /// <inheritdoc />
    public virtual string GenusName => "Diaphorapteryx";

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
