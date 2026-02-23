using AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Emeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Emeidae.Pachyornis;

/// <summary>
/// Abstract class for Pachyornis (genus).
/// NCBI TaxId: 8814
/// </summary>
public abstract class Pachyornis : Emeidae, IPachyornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachyornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8814;

    /// <inheritdoc />
    public virtual string GenusName => "Pachyornis";

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
