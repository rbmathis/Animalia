using AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Emeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Emeidae.Euryapteryx;

/// <summary>
/// Abstract class for Euryapteryx (genus).
/// NCBI TaxId: 230979
/// </summary>
public abstract class Euryapteryx : Emeidae, IEuryapteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euryapteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 230979;

    /// <inheritdoc />
    public virtual string GenusName => "Euryapteryx";

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
