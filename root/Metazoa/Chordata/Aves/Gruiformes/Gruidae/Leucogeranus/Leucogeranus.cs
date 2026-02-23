using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Leucogeranus;

/// <summary>
/// Abstract class for Leucogeranus (genus).
/// NCBI TaxId: 3150792
/// </summary>
public abstract class Leucogeranus : Gruidae, ILeucogeranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucogeranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150792;

    /// <inheritdoc />
    public virtual string GenusName => "Leucogeranus";

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
